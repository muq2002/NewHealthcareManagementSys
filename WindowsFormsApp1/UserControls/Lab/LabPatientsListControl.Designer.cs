namespace HealthcareManagement.Screens.UserControls
{
    partial class LabPatientsListControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabPatientsListControl));
            this.containerPanel = new System.Windows.Forms.Panel();
            this.labPatientProfile1 = new HealthcareManagement.UserControls.Lab.LabPatientProfileControl();
            this.dataPatients = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleOfPageText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchPatientText = new Bunifu.Framework.UI.BunifuTextbox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.picData = new System.Windows.Forms.PictureBox();
            this.containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPatients)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picData)).BeginInit();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.labPatientProfile1);
            this.containerPanel.Controls.Add(this.dataPatients);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerPanel.Location = new System.Drawing.Point(30, 94);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(983, 687);
            this.containerPanel.TabIndex = 11;
            // 
            // labPatientProfile1
            // 
            this.labPatientProfile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.labPatientProfile1.Font = new System.Drawing.Font("Nunito", 14F);
            this.labPatientProfile1.Location = new System.Drawing.Point(0, 0);
            this.labPatientProfile1.Margin = new System.Windows.Forms.Padding(5);
            this.labPatientProfile1.Name = "labPatientProfile1";
            this.labPatientProfile1.patientId = 0;
            this.labPatientProfile1.Size = new System.Drawing.Size(1043, 805);
            this.labPatientProfile1.TabIndex = 4;
            this.labPatientProfile1.Visible = false;
            // 
            // dataPatients
            // 
            this.dataPatients.AllowUserToAddRows = false;
            this.dataPatients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataPatients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            this.dataPatients.Size = new System.Drawing.Size(983, 687);
            this.dataPatients.TabIndex = 3;
            this.dataPatients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPatients_CellDoubleClick);
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
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Age";
            this.Column3.Name = "Column3";
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
            this.Column6.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Order Date";
            this.Column5.Name = "Column5";
            this.Column5.Width = 260;
            // 
            // titleOfPageText
            // 
            this.titleOfPageText.AutoSize = true;
            this.titleOfPageText.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleOfPageText.Location = new System.Drawing.Point(85, 25);
            this.titleOfPageText.Name = "titleOfPageText";
            this.titleOfPageText.Size = new System.Drawing.Size(177, 38);
            this.titleOfPageText.TabIndex = 4;
            this.titleOfPageText.Text = "Patients List ";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(649, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 94);
            this.panel3.TabIndex = 3;
            // 
            // searchPatientText
            // 
            this.searchPatientText.BackColor = System.Drawing.Color.White;
            this.searchPatientText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchPatientText.BackgroundImage")));
            this.searchPatientText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchPatientText.ForeColor = System.Drawing.Color.Gainsboro;
            this.searchPatientText.Icon = ((System.Drawing.Image)(resources.GetObject("searchPatientText.Icon")));
            this.searchPatientText.Location = new System.Drawing.Point(678, 25);
            this.searchPatientText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchPatientText.Name = "searchPatientText";
            this.searchPatientText.Size = new System.Drawing.Size(345, 48);
            this.searchPatientText.TabIndex = 0;
            this.searchPatientText.text = "Search";
            this.searchPatientText.OnTextChange += new System.EventHandler(this.searchPatientText_OnTextChange);
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 94);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(30, 687);
            this.leftPanel.TabIndex = 9;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1013, 94);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(30, 687);
            this.rightPanel.TabIndex = 8;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 781);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1043, 24);
            this.BottomPanel.TabIndex = 7;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.picData);
            this.topPanel.Controls.Add(this.titleOfPageText);
            this.topPanel.Controls.Add(this.panel3);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1043, 94);
            this.topPanel.TabIndex = 6;
            // 
            // picData
            // 
            this.picData.Image = ((System.Drawing.Image)(resources.GetObject("picData.Image")));
            this.picData.Location = new System.Drawing.Point(30, 19);
            this.picData.Name = "picData";
            this.picData.Size = new System.Drawing.Size(49, 44);
            this.picData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picData.TabIndex = 7;
            this.picData.TabStop = false;
            this.picData.Visible = false;
            this.picData.Click += new System.EventHandler(this.picData_Click);
            // 
            // LabPatientsListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.searchPatientText);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Nunito", 8F);
            this.Name = "LabPatientsListControl";
            this.Size = new System.Drawing.Size(1043, 805);
            this.Load += new System.EventHandler(this.LabPatientsListControl_Load);
            this.containerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPatients)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel containerPanel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataPatients;
        private Bunifu.Framework.UI.BunifuCustomLabel titleOfPageText;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuTextbox searchPatientText;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox picData;
        private HealthcareManagement.UserControls.Lab.LabPatientProfileControl labPatientProfile1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
