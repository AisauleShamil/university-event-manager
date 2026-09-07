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

namespace UniversityEventManager
{
    public partial class RegistrationsUserControl : UserControl
    {
        public RegistrationsUserControl()
        {
            InitializeComponent();
            LoadRegistrations();

            txtFilter.TextChanged += txtFilter_TextChanged;

        }
        private void LoadRegistrations()
        {
            using UniversityEventDbContext db = new UniversityEventDbContext();

            string filter = txtFilter.Text.ToLower();

            var registrations = db.Registrations
                .Include(r => r.Event)
                .Include(r => r.Participant)
                .Where(s =>
                    s.Event.Title.ToLower().Contains(filter) ||
                    s.Participant.FullName.ToLower().Contains(filter))
                .Select(r => new
                {
                    r.RegistrationId,
                    Event = r.Event.Title,
                    Participant = r.Participant.FullName,
                    r.RegistrationDate
                })
                .ToList();

            dgvRegistrations.DataSource = registrations;
        }

        private void txtFilter_TextChanged(object? sender, EventArgs e)
        {
            LoadRegistrations();
        }
    }
}
