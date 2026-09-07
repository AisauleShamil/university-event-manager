namespace UniversityEventManager
{
    partial class SpeakersUserControl
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
            txtSpeakerFilter = new TextBox();
            dgvSpeakers = new DataGridView();
            btnDeleteSpeaker = new Button();
            lblFilter = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSpeakers).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(58, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Speakers";
            // 
            // txtSpeakerFilter
            // 
            txtSpeakerFilter.Location = new Point(170, 62);
            txtSpeakerFilter.Margin = new Padding(2);
            txtSpeakerFilter.Name = "txtSpeakerFilter";
            txtSpeakerFilter.Size = new Size(108, 23);
            txtSpeakerFilter.TabIndex = 1;
            // 
            // dgvSpeakers
            // 
            dgvSpeakers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSpeakers.Location = new Point(65, 98);
            dgvSpeakers.Margin = new Padding(2);
            dgvSpeakers.Name = "dgvSpeakers";
            dgvSpeakers.RowHeadersWidth = 62;
            dgvSpeakers.Size = new Size(435, 234);
            dgvSpeakers.TabIndex = 2;
            // 
            // btnDeleteSpeaker
            // 
            btnDeleteSpeaker.Location = new Point(338, 65);
            btnDeleteSpeaker.Margin = new Padding(2);
            btnDeleteSpeaker.Name = "btnDeleteSpeaker";
            btnDeleteSpeaker.Size = new Size(140, 20);
            btnDeleteSpeaker.TabIndex = 3;
            btnDeleteSpeaker.Text = "Delete selected speaker";
            btnDeleteSpeaker.UseVisualStyleBackColor = true;
            btnDeleteSpeaker.Click += btnDeleteSpeaker_Click;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(65, 65);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(100, 15);
            lblFilter.TabIndex = 4;
            lblFilter.Text = "Filter your search:";
            // 
            // SpeakersUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblFilter);
            Controls.Add(btnDeleteSpeaker);
            Controls.Add(dgvSpeakers);
            Controls.Add(txtSpeakerFilter);
            Controls.Add(lblTitle);
            Margin = new Padding(2);
            Name = "SpeakersUserControl";
            Size = new Size(572, 375);
            ((System.ComponentModel.ISupportInitialize)dgvSpeakers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtSpeakerFilter;
        private DataGridView dgvSpeakers;
        private Button btnDeleteSpeaker;
        private Label lblFilter;
    }
}
