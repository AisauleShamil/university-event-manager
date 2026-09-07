namespace UniversityEventManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuPanel = new FlowLayoutPanel();
            btnEvents = new Button();
            btnSpeakers = new Button();
            btnRegistrations = new Button();
            mainPanel = new Panel();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(btnEvents);
            menuPanel.Controls.Add(btnSpeakers);
            menuPanel.Controls.Add(btnRegistrations);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Margin = new Padding(2);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(135, 270);
            menuPanel.TabIndex = 0;
            // 
            // btnEvents
            // 
            btnEvents.Location = new Point(2, 2);
            btnEvents.Margin = new Padding(2);
            btnEvents.Name = "btnEvents";
            btnEvents.Size = new Size(123, 30);
            btnEvents.TabIndex = 0;
            btnEvents.Text = "Events";
            btnEvents.UseVisualStyleBackColor = true;
            btnEvents.Click += btnEvents_Click;
            // 
            // btnSpeakers
            // 
            btnSpeakers.Location = new Point(2, 36);
            btnSpeakers.Margin = new Padding(2);
            btnSpeakers.Name = "btnSpeakers";
            btnSpeakers.Size = new Size(123, 28);
            btnSpeakers.TabIndex = 1;
            btnSpeakers.Text = "Speakers";
            btnSpeakers.UseVisualStyleBackColor = true;
            btnSpeakers.Click += btnSpeakers_Click;
            // 
            // btnRegistrations
            // 
            btnRegistrations.Location = new Point(2, 68);
            btnRegistrations.Margin = new Padding(2);
            btnRegistrations.Name = "btnRegistrations";
            btnRegistrations.Size = new Size(123, 30);
            btnRegistrations.TabIndex = 2;
            btnRegistrations.Text = "Registrations";
            btnRegistrations.UseVisualStyleBackColor = true;
            btnRegistrations.Click += btnRegistrations_Click;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(135, 0);
            mainPanel.Margin = new Padding(2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(425, 270);
            mainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(mainPanel);
            Controls.Add(menuPanel);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "University Event Manager";
            menuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel menuPanel;
        private Panel mainPanel;
        private Button btnEvents;
        private Button btnSpeakers;
        private Button btnRegistrations;
    }
}
