namespace UniversityEventManager
{
    partial class EventsUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvEvents = new DataGridView();
            txtFilter = new TextBox();
            btnDeleteEvent = new Button();
            btnExportCSV = new Button();
            btnAddEvent = new Button();
            btnAddEventSpeaker = new Button();
            txtSelectedTitle = new TextBox();
            txtSelectedDescription = new TextBox();
            dtpSelectedDate = new DateTimePicker();
            txtSelectedRoom = new TextBox();
            txtSelectedDepartment = new TextBox();
            lblFilter = new Label();
            lblSelectedDepartment = new Label();
            lblSelectedRoom = new Label();
            lblSelectedDescription = new Label();
            lblSelectedTitle = new Label();
            lblSelectedDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(47, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Events";
            // 
            // dgvEvents
            // 
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Location = new Point(14, 241);
            dgvEvents.Margin = new Padding(2);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.RowHeadersWidth = 62;
            dgvEvents.Size = new Size(456, 222);
            dgvEvents.TabIndex = 1;
            // 
            // txtFilter
            // 
            txtFilter.BackColor = SystemColors.Window;
            txtFilter.Location = new Point(152, 56);
            txtFilter.Margin = new Padding(2);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(101, 23);
            txtFilter.TabIndex = 2;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // btnDeleteEvent
            // 
            btnDeleteEvent.Location = new Point(531, 83);
            btnDeleteEvent.Margin = new Padding(2);
            btnDeleteEvent.Name = "btnDeleteEvent";
            btnDeleteEvent.Size = new Size(135, 27);
            btnDeleteEvent.TabIndex = 3;
            btnDeleteEvent.Text = "Delete Selected Event";
            btnDeleteEvent.UseVisualStyleBackColor = true;
            btnDeleteEvent.Click += btnDeleteEvent_Click;
            // 
            // btnExportCSV
            // 
            btnExportCSV.Location = new Point(396, 83);
            btnExportCSV.Margin = new Padding(2);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(131, 27);
            btnExportCSV.TabIndex = 4;
            btnExportCSV.Text = "Export events to CSV";
            btnExportCSV.UseVisualStyleBackColor = true;
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(296, 83);
            btnAddEvent.Margin = new Padding(2);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(96, 27);
            btnAddEvent.TabIndex = 5;
            btnAddEvent.Text = "Add New Event";
            btnAddEvent.UseVisualStyleBackColor = true;
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // btnAddEventSpeaker
            // 
            btnAddEventSpeaker.BackColor = SystemColors.Window;
            btnAddEventSpeaker.Location = new Point(152, 83);
            btnAddEventSpeaker.Margin = new Padding(2);
            btnAddEventSpeaker.Name = "btnAddEventSpeaker";
            btnAddEventSpeaker.Size = new Size(140, 27);
            btnAddEventSpeaker.TabIndex = 6;
            btnAddEventSpeaker.Text = "Assign speaker to event";
            btnAddEventSpeaker.UseVisualStyleBackColor = false;
            btnAddEventSpeaker.Click += btnAddEventSpeaker_Click;
            // 
            // txtSelectedTitle
            // 
            txtSelectedTitle.Location = new Point(152, 111);
            txtSelectedTitle.Margin = new Padding(2);
            txtSelectedTitle.Name = "txtSelectedTitle";
            txtSelectedTitle.Size = new Size(318, 23);
            txtSelectedTitle.TabIndex = 7;
            // 
            // txtSelectedDescription
            // 
            txtSelectedDescription.Location = new Point(152, 137);
            txtSelectedDescription.Margin = new Padding(2);
            txtSelectedDescription.Name = "txtSelectedDescription";
            txtSelectedDescription.Size = new Size(318, 23);
            txtSelectedDescription.TabIndex = 8;
            // 
            // dtpSelectedDate
            // 
            dtpSelectedDate.Location = new Point(152, 164);
            dtpSelectedDate.Margin = new Padding(2);
            dtpSelectedDate.Name = "dtpSelectedDate";
            dtpSelectedDate.Size = new Size(318, 23);
            dtpSelectedDate.TabIndex = 9;
            // 
            // txtSelectedRoom
            // 
            txtSelectedRoom.BackColor = SystemColors.Window;
            txtSelectedRoom.ForeColor = SystemColors.WindowFrame;
            txtSelectedRoom.Location = new Point(152, 189);
            txtSelectedRoom.Margin = new Padding(2);
            txtSelectedRoom.Name = "txtSelectedRoom";
            txtSelectedRoom.Size = new Size(318, 23);
            txtSelectedRoom.TabIndex = 10;
            // 
            // txtSelectedDepartment
            // 
            txtSelectedDepartment.BackColor = SystemColors.Window;
            txtSelectedDepartment.Location = new Point(152, 214);
            txtSelectedDepartment.Margin = new Padding(2);
            txtSelectedDepartment.Name = "txtSelectedDepartment";
            txtSelectedDepartment.Size = new Size(318, 23);
            txtSelectedDepartment.TabIndex = 11;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(14, 66);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(100, 15);
            lblFilter.TabIndex = 12;
            lblFilter.Text = "Filter your search:";
            // 
            // lblSelectedDepartment
            // 
            lblSelectedDepartment.AutoSize = true;
            lblSelectedDepartment.Location = new Point(14, 217);
            lblSelectedDepartment.Name = "lblSelectedDepartment";
            lblSelectedDepartment.Size = new Size(120, 15);
            lblSelectedDepartment.TabIndex = 13;
            lblSelectedDepartment.Text = "Selected Department:";
            // 
            // lblSelectedRoom
            // 
            lblSelectedRoom.AutoSize = true;
            lblSelectedRoom.Location = new Point(14, 192);
            lblSelectedRoom.Name = "lblSelectedRoom";
            lblSelectedRoom.Size = new Size(89, 15);
            lblSelectedRoom.TabIndex = 14;
            lblSelectedRoom.Text = "Selected Room:";
            // 
            // lblSelectedDescription
            // 
            lblSelectedDescription.AutoSize = true;
            lblSelectedDescription.Location = new Point(14, 141);
            lblSelectedDescription.Name = "lblSelectedDescription";
            lblSelectedDescription.Size = new Size(117, 15);
            lblSelectedDescription.TabIndex = 15;
            lblSelectedDescription.Text = "Selected Description:";
            // 
            // lblSelectedTitle
            // 
            lblSelectedTitle.AutoSize = true;
            lblSelectedTitle.Location = new Point(14, 114);
            lblSelectedTitle.Name = "lblSelectedTitle";
            lblSelectedTitle.Size = new Size(80, 15);
            lblSelectedTitle.TabIndex = 16;
            lblSelectedTitle.Text = "Selected Title:";
            // 
            // lblSelectedDate
            // 
            lblSelectedDate.AutoSize = true;
            lblSelectedDate.Location = new Point(14, 164);
            lblSelectedDate.Name = "lblSelectedDate";
            lblSelectedDate.Size = new Size(81, 15);
            lblSelectedDate.TabIndex = 17;
            lblSelectedDate.Text = "Selected Date:";
            // 
            // EventsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblSelectedDate);
            Controls.Add(lblSelectedTitle);
            Controls.Add(lblSelectedDescription);
            Controls.Add(lblSelectedRoom);
            Controls.Add(lblSelectedDepartment);
            Controls.Add(lblFilter);
            Controls.Add(txtSelectedDepartment);
            Controls.Add(txtSelectedRoom);
            Controls.Add(dtpSelectedDate);
            Controls.Add(txtSelectedDescription);
            Controls.Add(txtSelectedTitle);
            Controls.Add(dgvEvents);
            Controls.Add(btnAddEventSpeaker);
            Controls.Add(btnAddEvent);
            Controls.Add(btnExportCSV);
            Controls.Add(btnDeleteEvent);
            Controls.Add(txtFilter);
            Controls.Add(lblTitle);
            Margin = new Padding(2);
            Name = "EventsUserControl";
            Size = new Size(775, 481);
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvEvents;
        private TextBox txtFilter;
        private Button btnDeleteEvent;
        private Button btnExportCSV;
        private Button btnAddEvent;
        private Button btnAddEventSpeaker;
        private TextBox txtSelectedTitle;
        private TextBox txtSelectedDescription;
        private DateTimePicker dtpSelectedDate;
        private TextBox txtSelectedRoom;
        private TextBox txtSelectedDepartment;
        private Label lblFilter;
        private Label lblSelectedDepartment;
        private Label lblSelectedRoom;
        private Label lblSelectedDescription;
        private Label lblSelectedTitle;
        private Label lblSelectedDate;
    }
}
