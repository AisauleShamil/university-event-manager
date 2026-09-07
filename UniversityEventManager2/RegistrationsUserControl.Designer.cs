namespace UniversityEventManager
{
    partial class RegistrationsUserControl
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
            dgvRegistrations = new DataGridView();
            txtFilter = new TextBox();
            lblFilter = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRegistrations).BeginInit();
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
            lblTitle.Size = new Size(80, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registrations";
            // 
            // dgvRegistrations
            // 
            dgvRegistrations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistrations.Location = new Point(79, 75);
            dgvRegistrations.Margin = new Padding(2);
            dgvRegistrations.Name = "dgvRegistrations";
            dgvRegistrations.RowHeadersWidth = 62;
            dgvRegistrations.Size = new Size(541, 343);
            dgvRegistrations.TabIndex = 1;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(170, 50);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(100, 23);
            txtFilter.TabIndex = 2;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(89, 53);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(36, 15);
            lblFilter.TabIndex = 3;
            lblFilter.Text = "Filter:";
            // 
            // RegistrationsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblFilter);
            Controls.Add(txtFilter);
            Controls.Add(dgvRegistrations);
            Controls.Add(lblTitle);
            Margin = new Padding(2);
            Name = "RegistrationsUserControl";
            Size = new Size(716, 488);
            ((System.ComponentModel.ISupportInitialize)dgvRegistrations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvRegistrations;
        private TextBox txtFilter;
        private Label lblFilter;
    }
}
