using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using UniversityEventManager.Models;
using System.IO;

namespace UniversityEventManager
{
    public partial class EventsUserControl : UserControl
    {
        BindingSource eventBindingSource = new BindingSource();
        public EventsUserControl()
        {
            InitializeComponent();
            LoadEvents();
        }
        private void LoadEvents()
        {
            using UniversityEventDbContext db = new UniversityEventDbContext();

            string filter = txtFilter.Text.Trim().ToLower();

            var query = db.Events
                .Include(e => e.Room)
                .Include(e => e.Department)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter))
            {
                query = query.Where(e =>
                    e.Title.ToLower().Contains(filter) ||
                    e.Description.ToLower().Contains(filter) ||
                    e.Room.Name.ToLower().Contains(filter) ||
                    e.Department.Name.ToLower().Contains(filter));
            }

            var events = query
                .Select(e => new
                {
                    e.EventId,
                    e.Title,
                    e.Description,
                    e.EventDate,
                    Room = e.Room.Name,
                    Department = e.Department.Name
                })
                .ToList();

            eventBindingSource.DataSource = events;
            dgvEvents.DataSource = eventBindingSource;
            BindDetailControls();
        }
        private void BindDetailControls()
        {
            txtSelectedTitle.DataBindings.Clear();
            txtSelectedDescription.DataBindings.Clear();
            dtpSelectedDate.DataBindings.Clear();
            txtSelectedRoom.DataBindings.Clear();
            txtSelectedDepartment.DataBindings.Clear();

            txtSelectedTitle.DataBindings.Add("Text", eventBindingSource, "Title");
            txtSelectedDescription.DataBindings.Add("Text", eventBindingSource, "Description");
            dtpSelectedDate.DataBindings.Add("Value", eventBindingSource, "EventDate");
            txtSelectedRoom.DataBindings.Add("Text", eventBindingSource, "Room");
            txtSelectedDepartment.DataBindings.Add("Text", eventBindingSource, "Department");
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            if (dgvEvents.CurrentRow == null)
            {
                MessageBox.Show("Please select an event first.");
                return;
            }

            int eventId = Convert.ToInt32(dgvEvents.CurrentRow.Cells["EventId"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this event?",
                "Delete confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            using UniversityEventDbContext db = new UniversityEventDbContext();

            var eventSpeakers = db.EventSpeakers.Where(es => es.EventId == eventId).ToList();
            db.EventSpeakers.RemoveRange(eventSpeakers);

            var registrations = db.Registrations.Where(r => r.EventId == eventId).ToList();
            db.Registrations.RemoveRange(registrations);

            var selectedEvent = db.Events.Find(eventId);

            if (selectedEvent != null)
            {
                db.Events.Remove(selectedEvent);
                db.SaveChanges();
                LoadEvents();
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Save events to CSV";
            saveFileDialog.FileName = "events.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using UniversityEventDbContext db = new UniversityEventDbContext();

                var events = db.Events
                    .Include(e => e.Room)
                    .Include(e => e.Department)
                    .Select(e => new
                    {
                        e.Title,
                        e.Description,
                        e.EventDate,
                        Room = e.Room.Name,
                        Department = e.Department.Name
                    })
                    .ToList();

                using StreamWriter writer = new StreamWriter(saveFileDialog.FileName);

                writer.WriteLine("Title,Description,EventDate,Room,Department");

                foreach (var item in events)
                {
                    writer.WriteLine($"\"{item.Title}\",\"{item.Description}\",\"{item.EventDate}\",\"{item.Room}\",\"{item.Department}\"");
                }

                MessageBox.Show("CSV file saved successfully.");
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            AddEventForm form = new AddEventForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadEvents();
            }
        }

        private void btnAddEventSpeaker_Click(object sender, EventArgs e)
        {
            AddEventSpeakerForm form = new AddEventSpeakerForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Speaker assigned to event.");
            }
        }
    }
}
