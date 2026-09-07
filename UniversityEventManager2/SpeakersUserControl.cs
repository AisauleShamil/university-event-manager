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
    public partial class SpeakersUserControl : UserControl
    {
        public SpeakersUserControl()
        {
            InitializeComponent();
            LoadSpeakers();

            txtSpeakerFilter.TextChanged += txtSpeakerFilter_TextChanged;
        }
        private void LoadSpeakers()
        {
            using UniversityEventDbContext db = new UniversityEventDbContext();

            string filter = txtSpeakerFilter.Text.ToLower();

            var speakers = db.Speakers
                .Where(s =>
                    s.FullName.ToLower().Contains(filter) ||
                    s.Email.ToLower().Contains(filter) ||
                    s.Expertise.ToLower().Contains(filter))
                .Select(s => new
                {
                    s.SpeakerId,
                    s.FullName,
                    s.Email,
                    s.Expertise
                })
                .ToList();

            dgvSpeakers.DataSource = speakers;
        }

        private void txtSpeakerFilter_TextChanged(object? sender, EventArgs e)
        {
            LoadSpeakers();
        }

        private void btnDeleteSpeaker_Click(object sender, EventArgs e)
        {
            if (dgvSpeakers.CurrentRow == null)
            {
                MessageBox.Show("Please select a speaker first.");
                return;
            }

            int speakerId = Convert.ToInt32(dgvSpeakers.CurrentRow.Cells["SpeakerId"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this speaker?",
                "Delete confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            using UniversityEventDbContext db = new UniversityEventDbContext();

            var eventSpeakers = db.EventSpeakers
                .Where(es => es.SpeakerId == speakerId)
                .ToList();

            db.EventSpeakers.RemoveRange(eventSpeakers);

            var selectedSpeaker = db.Speakers.Find(speakerId);

            if (selectedSpeaker != null)
            {
                db.Speakers.Remove(selectedSpeaker);
                db.SaveChanges();
                LoadSpeakers();
            }
        }
    }
}
