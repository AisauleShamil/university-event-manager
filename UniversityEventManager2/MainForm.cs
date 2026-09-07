using System.Drawing.Text;

namespace UniversityEventManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
        }

        private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        
        private void btnEvents_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            EventsUserControl eventsUserControl = new EventsUserControl();
            eventsUserControl.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(eventsUserControl);
        }
        private void btnSpeakers_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            SpeakersUserControl speakersUserControl = new SpeakersUserControl();
            speakersUserControl.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(speakersUserControl);
        }

        private void btnRegistrations_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            RegistrationsUserControl registrationsUserControl = new RegistrationsUserControl();
            registrationsUserControl.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(registrationsUserControl);
        }
    }
}





