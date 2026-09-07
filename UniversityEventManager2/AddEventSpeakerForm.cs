using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityEventManager.Models;

namespace UniversityEventManager
{
    public partial class AddEventSpeakerForm : Form
    {
        public AddEventSpeakerForm()
        {
            InitializeComponent();

            LoadComboBoxes();
            ValidateForm();

            cmbEvent.SelectedIndexChanged += ValidateInputs;
            cmbSpeaker.SelectedIndexChanged += ValidateInputs;
            txtRole.TextChanged += ValidateInputs;
        }
        private void LoadComboBoxes()
        {
            using UniversityEventDbContext db = new UniversityEventDbContext();

            cmbEvent.DataSource = db.Events.ToList();
            cmbEvent.DisplayMember = "Title";
            cmbEvent.ValueMember = "EventId";
            cmbEvent.SelectedIndex = -1;

            cmbSpeaker.DataSource = db.Speakers.ToList();
            cmbSpeaker.DisplayMember = "FullName";
            cmbSpeaker.ValueMember = "SpeakerId";
            cmbSpeaker.SelectedIndex = -1;
        }

        private void ValidateInputs(object? sender, EventArgs e)
        {
            ValidateForm();
        }

        private void ValidateForm()
        {
            bool isValid = true;

            errorProvider1.SetError(cmbEvent, "");
            errorProvider1.SetError(cmbSpeaker, "");
            errorProvider1.SetError(txtRole, "");

            if (cmbEvent.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbEvent, "Please select an event.");
                isValid = false;
            }

            if (cmbSpeaker.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbSpeaker, "Please select a speaker.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtRole.Text))
            {
                errorProvider1.SetError(txtRole, "Role is required.");
                isValid = false;
            }

            btnOk.Enabled = isValid;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ValidateForm();

            if (!btnOk.Enabled)
            {
                return;
            }

            using UniversityEventDbContext db = new UniversityEventDbContext();

            int eventId = Convert.ToInt32(cmbEvent.SelectedValue);
            int speakerId = Convert.ToInt32(cmbSpeaker.SelectedValue);

            bool alreadyExists = db.EventSpeakers.Any(es =>
                es.EventId == eventId &&
                es.SpeakerId == speakerId);

            if (alreadyExists)
            {
                MessageBox.Show("This speaker is already assigned to this event.");
                return;
            }

            EventSpeaker eventSpeaker = new EventSpeaker();

            eventSpeaker.EventId = eventId;
            eventSpeaker.SpeakerId = speakerId;
            eventSpeaker.Role = txtRole.Text;

            db.EventSpeakers.Add(eventSpeaker);
            db.SaveChanges();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
