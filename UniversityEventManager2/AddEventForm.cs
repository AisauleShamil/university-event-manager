using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using UniversityEventManager.Models;

namespace UniversityEventManager
{
    public partial class AddEventForm : Form
    {
        public AddEventForm()
        {
            InitializeComponent();

            LoadComboBoxes();
            ValidateForm();

            txtTitle.TextChanged += ValidateInputs;
            txtDescription.TextChanged += ValidateInputs;
            cmbRoom.SelectedIndexChanged += ValidateInputs;
            cmbDepartment.SelectedIndexChanged += ValidateInputs;
        }
        private void LoadComboBoxes()
        {
            using UniversityEventDbContext db = new UniversityEventDbContext();

            cmbRoom.DataSource = db.Rooms.ToList();
            cmbRoom.DisplayMember = "Name";
            cmbRoom.ValueMember = "RoomId";
            cmbRoom.SelectedIndex = -1;

            cmbDepartment.DataSource = db.Departments.ToList();
            cmbDepartment.DisplayMember = "Name";
            cmbDepartment.ValueMember = "DepartmentId";
            cmbDepartment.SelectedIndex = -1;
        }

        private void ValidateInputs(object? sender, EventArgs e)
        {
            ValidateForm();
        }

        private void ValidateForm()
        {
            bool isValid = true;

            errorProvider1.SetError(txtTitle, "");
            errorProvider1.SetError(txtDescription, "");
            errorProvider1.SetError(cmbRoom, "");
            errorProvider1.SetError(cmbDepartment, "");

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                errorProvider1.SetError(txtTitle, "Title is required.");
                isValid = false;
            }
            else if (!Regex.IsMatch(txtTitle.Text, @"^[A-ZÁÉÍÓÖŐÚÜŰ].+"))
            {
                errorProvider1.SetError(txtTitle, "Title must start with a capital letter.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorProvider1.SetError(txtDescription, "Description is required.");
                isValid = false;
            }
            else if (!Regex.IsMatch(txtDescription.Text, @"^.{10,}$"))
            {
                errorProvider1.SetError(txtDescription, "Description must be at least 10 characters.");
                isValid = false;
            }

            if (cmbRoom.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbRoom, "Please select a room.");
                isValid = false;
            }

            if (cmbDepartment.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbDepartment, "Please select a department.");
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

            Event newEvent = new Event();

            newEvent.Title = txtTitle.Text;
            newEvent.Description = txtDescription.Text;
            newEvent.EventDate = dtpEventDate.Value;
            newEvent.RoomId = Convert.ToInt32(cmbRoom.SelectedValue);
            newEvent.DepartmentId = Convert.ToInt32(cmbDepartment.SelectedValue);

            db.Events.Add(newEvent);
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
