namespace UniversityEventManager
{
    partial class AddEventSpeakerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cmbEvent = new ComboBox();
            cmbSpeaker = new ComboBox();
            txtRole = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            lblEvent = new Label();
            lblSpeaker = new Label();
            lblRole = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cmbEvent
            // 
            cmbEvent.FormattingEnabled = true;
            cmbEvent.Location = new Point(94, 8);
            cmbEvent.Margin = new Padding(2, 2, 2, 2);
            cmbEvent.Name = "cmbEvent";
            cmbEvent.Size = new Size(129, 23);
            cmbEvent.TabIndex = 0;
            // 
            // cmbSpeaker
            // 
            cmbSpeaker.FormattingEnabled = true;
            cmbSpeaker.Location = new Point(94, 35);
            cmbSpeaker.Margin = new Padding(2, 2, 2, 2);
            cmbSpeaker.Name = "cmbSpeaker";
            cmbSpeaker.Size = new Size(129, 23);
            cmbSpeaker.TabIndex = 1;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(94, 62);
            txtRole.Margin = new Padding(2, 2, 2, 2);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(106, 23);
            txtRole.TabIndex = 2;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(30, 101);
            btnOk.Margin = new Padding(2, 2, 2, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(78, 20);
            btnOk.TabIndex = 3;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(145, 101);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(78, 20);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblEvent
            // 
            lblEvent.AutoSize = true;
            lblEvent.Location = new Point(26, 11);
            lblEvent.Name = "lblEvent";
            lblEvent.Size = new Size(39, 15);
            lblEvent.TabIndex = 5;
            lblEvent.Text = "Event:";
            // 
            // lblSpeaker
            // 
            lblSpeaker.AutoSize = true;
            lblSpeaker.Location = new Point(26, 38);
            lblSpeaker.Name = "lblSpeaker";
            lblSpeaker.Size = new Size(48, 15);
            lblSpeaker.TabIndex = 6;
            lblSpeaker.Text = "Speaker";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(26, 65);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(33, 15);
            lblRole.TabIndex = 7;
            lblRole.Text = "Role:";
            // 
            // AddEventSpeakerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(lblRole);
            Controls.Add(lblSpeaker);
            Controls.Add(lblEvent);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(txtRole);
            Controls.Add(cmbSpeaker);
            Controls.Add(cmbEvent);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AddEventSpeakerForm";
            Text = "AddEventSpeakerForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEvent;
        private ComboBox cmbSpeaker;
        private TextBox txtRole;
        private Button btnOk;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
        private Label lblRole;
        private Label lblSpeaker;
        private Label lblEvent;
    }
}