namespace UniversityEventManager
{
    partial class AddEventForm
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
            components = new System.ComponentModel.Container();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            dtpEventDate = new DateTimePicker();
            cmbRoom = new ComboBox();
            cmbDepartment = new ComboBox();
            btnOk = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            lblTitle = new Label();
            lblDescription = new Label();
            lblEventDate = new Label();
            lblRoom = new Label();
            lblDepartment = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(137, 13);
            txtTitle.Margin = new Padding(2, 2, 2, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(106, 23);
            txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(137, 40);
            txtDescription.Margin = new Padding(2, 2, 2, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(106, 23);
            txtDescription.TabIndex = 1;
            // 
            // dtpEventDate
            // 
            dtpEventDate.Location = new Point(137, 67);
            dtpEventDate.Margin = new Padding(2, 2, 2, 2);
            dtpEventDate.Name = "dtpEventDate";
            dtpEventDate.Size = new Size(211, 23);
            dtpEventDate.TabIndex = 2;
            // 
            // cmbRoom
            // 
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(137, 94);
            cmbRoom.Margin = new Padding(2, 2, 2, 2);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(129, 23);
            cmbRoom.TabIndex = 3;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(137, 121);
            cmbDepartment.Margin = new Padding(2, 2, 2, 2);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(129, 23);
            cmbDepartment.TabIndex = 4;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(27, 198);
            btnOk.Margin = new Padding(2, 2, 2, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(78, 20);
            btnOk.TabIndex = 5;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(120, 198);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(78, 20);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(27, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(33, 15);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Title:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(27, 43);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description:";
            // 
            // lblEventDate
            // 
            lblEventDate.AutoSize = true;
            lblEventDate.Location = new Point(27, 75);
            lblEventDate.Name = "lblEventDate";
            lblEventDate.Size = new Size(66, 15);
            lblEventDate.TabIndex = 9;
            lblEventDate.Text = "Event Date:";
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(27, 102);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(42, 15);
            lblRoom.TabIndex = 10;
            lblRoom.Text = "Room:";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(27, 124);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(73, 15);
            lblDepartment.TabIndex = 11;
            lblDepartment.Text = "Department:";
            // 
            // AddEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 263);
            Controls.Add(lblDepartment);
            Controls.Add(lblRoom);
            Controls.Add(lblEventDate);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(cmbDepartment);
            Controls.Add(cmbRoom);
            Controls.Add(dtpEventDate);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AddEventForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtDescription;
        private DateTimePicker dtpEventDate;
        private ComboBox cmbRoom;
        private ComboBox cmbDepartment;
        private Button btnOk;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
        private Label lblEventDate;
        private Label lblDescription;
        private Label lblTitle;
        private Label lblDepartment;
        private Label lblRoom;
    }
}
