namespace HealthcareManagementSystem.UserControls.Pharmacy
{
    partial class PharmacyPatientsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacyPatientsList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.titleOfPageText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchPatientText = new Bunifu.Framework.UI.BunifuTextbox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.picData = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.pharmacyPatientProfileControl1 = new HealthcareManagement.UserControls.Pharmacy.PharmacyPatientProfileControl();
            this.dataPatients = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picData)).BeginInit();
            this.containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1013, 85);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(30, 620);
            this.rightPanel.TabIndex = 14;
            // 
            // titleOfPageText
            // 
            this.titleOfPageText.AutoSize = true;
            this.titleOfPageText.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleOfPageText.Location = new System.Drawing.Point(71, 29);
            this.titleOfPageText.Name = "titleOfPageText";
            this.titleOfPageText.Size = new System.Drawing.Size(170, 38);
            this.titleOfPageText.TabIndex = 4;
            this.titleOfPageText.Text = "Patients List";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.searchPatientText);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(619, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 85);
            this.panel3.TabIndex = 3;
            // 
            // searchPatientText
            // 
            this.searchPatientText.BackColor = System.Drawing.Color.White;
            this.searchPatientText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchPatientText.BackgroundImage")));
            this.searchPatientText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchPatientText.ForeColor = System.Drawing.Color.Gainsboro;
            this.searchPatientText.Icon = ((System.Drawing.Image)(resources.GetObject("searchPatientText.Icon")));
            this.searchPatientText.Location = new System.Drawing.Point(23, 23);
            this.searchPatientText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchPatientText.Name = "searchPatientText";
            this.searchPatientText.Size = new System.Drawing.Size(345, 44);
            this.searchPatientText.TabIndex = 0;
            this.searchPatientText.text = "Search";
            this.searchPatientText.OnTextChange += new System.EventHandler(this.searchPatientText_OnTextChange);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.picData);
            this.topPanel.Controls.Add(this.titleOfPageText);
            this.topPanel.Controls.Add(this.panel3);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(30, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1013, 85);
            this.topPanel.TabIndex = 12;
            // 
            // picData
            // 
            this.picData.Image = ((System.Drawing.Image)(resources.GetObject("picData.Image")));
            this.picData.Location = new System.Drawing.Point(16, 23);
            this.picData.Name = "picData";
            this.picData.Size = new System.Drawing.Size(49, 44);
            this.picData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picData.TabIndex = 7;
            this.picData.TabStop = false;
            this.picData.Visible = false;
            this.picData.Click += new System.EventHandler(this.picData_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(30, 705);
            this.leftPanel.TabIndex = 15;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 705);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1043, 27);
            this.BottomPanel.TabIndex = 13;
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.pharmacyPatientProfileControl1);
            this.containerPanel.Controls.Add(this.dataPatients);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerPanel.Location = new System.Drawing.Point(30, 85);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(983, 620);
            this.containerPanel.TabIndex = 18;
            // 
            // pharmacyPatientProfileControl1
            // 
            this.pharmacyPatientProfileControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pharmacyPatientProfileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pharmacyPatientProfileControl1.Font = new System.Drawing.Font("Nunito", 8F);
            this.pharmacyPatientProfileControl1.Location = new System.Drawing.Point(0, 0);
            this.pharmacyPatientProfileControl1.Name = "pharmacyPatientProfileControl1";
            this.pharmacyPatientProfileControl1.patientId = 0;
            this.pharmacyPatientProfileControl1.Size = new System.Drawing.Size(983, 620);
            this.pharmacyPatientProfileControl1.TabIndex = 4;
            this.pharmacyPatientProfileControl1.Visible = false;
            // 
            // dataPatients
            // 
            this.dataPatients.AllowUserToAddRows = false;
            this.dataPatients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPatients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this._id,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dataPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPatients.DoubleBuffered = true;
            this.dataPatients.EnableHeadersVisualStyles = false;
            this.dataPatients.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.dataPatients.HeaderForeColor = System.Drawing.Color.White;
            this.dataPatients.Location = new System.Drawing.Point(0, 0);
            this.dataPatients.Name = "dataPatients";
            this.dataPatients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataPatients.RowHeadersWidth = 40;
            this.dataPatients.RowTemplate.Height = 28;
            this.dataPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPatients.Size = new System.Drawing.Size(983, 620);
            this.dataPatients.TabIndex = 3;
            this.dataPatients.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPatients_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // _id
            // 
            this._id.HeaderText = "_id";
            this._id.Name = "_id";
            this._id.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Age";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gender";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Phone Number";
            this.Column6.Name = "Column6";
            this.Column6.Width = 180;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Order Date";
            this.Column5.Name = "Column5";
            this.Column5.Width = 220;
            // 
            // PharmacyPatientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.BottomPanel);
            this.Font = new System.Drawing.Font("Nunito", 8F);
            this.Name = "PharmacyPatientsList";
            this.Size = new System.Drawing.Size(1043, 732);
            this.Load += new System.EventHandler(this.PharmacyPatientsList_Load);
            this.panel3.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picData)).EndInit();
            this.containerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rightPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel titleOfPageText;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuTextbox searchPatientText;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel containerPanel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.PictureBox picData;
        private HealthcareManagement.UserControls.Pharmacy.PharmacyPatientProfileControl pharmacyPatientProfileControl1;
    }
}
