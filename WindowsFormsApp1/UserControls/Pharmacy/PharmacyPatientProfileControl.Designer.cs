namespace HealthcareManagement.UserControls.Pharmacy
{
    partial class PharmacyPatientProfileControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataPrescription = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrescription)).BeginInit();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPrescription
            // 
            this.dataPrescription.AllowUserToAddRows = false;
            this.dataPrescription.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataPrescription.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPrescription.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataPrescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPrescription.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPrescription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPrescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dataPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPrescription.DoubleBuffered = true;
            this.dataPrescription.EnableHeadersVisualStyles = false;
            this.dataPrescription.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.dataPrescription.HeaderForeColor = System.Drawing.Color.White;
            this.dataPrescription.Location = new System.Drawing.Point(0, 0);
            this.dataPrescription.Name = "dataPrescription";
            this.dataPrescription.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataPrescription.RowHeadersWidth = 40;
            this.dataPrescription.RowTemplate.Height = 28;
            this.dataPrescription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPrescription.Size = new System.Drawing.Size(1043, 732);
            this.dataPrescription.TabIndex = 3;
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.containerPanel.Controls.Add(this.dataPrescription);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1043, 732);
            this.containerPanel.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Session";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Medicine Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Instructions";
            this.Column3.Name = "Column3";
            this.Column3.Width = 300;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // PharmacyPatientProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.containerPanel);
            this.Font = new System.Drawing.Font("Nunito", 8F);
            this.Name = "PharmacyPatientProfileControl";
            this.Size = new System.Drawing.Size(1043, 732);
            ((System.ComponentModel.ISupportInitialize)(this.dataPrescription)).EndInit();
            this.containerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal Bunifu.Framework.UI.BunifuCustomDataGrid dataPrescription;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
