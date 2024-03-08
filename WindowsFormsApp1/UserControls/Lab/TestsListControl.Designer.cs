namespace HealthcareManagementSystem.UserControls
{
    partial class TestsListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestsListControl));
            this.containerPanel = new System.Windows.Forms.Panel();
            this.dataTests = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addPatientBTN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.topPanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTests)).BeginInit();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.dataTests);
            this.containerPanel.Controls.Add(this.panel1);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerPanel.Location = new System.Drawing.Point(30, 94);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(983, 681);
            this.containerPanel.TabIndex = 11;
            // 
            // dataTests
            // 
            this.dataTests.AllowUserToAddRows = false;
            this.dataTests.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataTests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTests.DoubleBuffered = true;
            this.dataTests.EnableHeadersVisualStyles = false;
            this.dataTests.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.dataTests.HeaderForeColor = System.Drawing.Color.White;
            this.dataTests.Location = new System.Drawing.Point(0, 0);
            this.dataTests.Name = "dataTests";
            this.dataTests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTests.RowHeadersWidth = 40;
            this.dataTests.RowTemplate.Height = 28;
            this.dataTests.Size = new System.Drawing.Size(983, 636);
            this.dataTests.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Patient Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Test Name";
            this.Column3.Name = "Column3";
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Device Name";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Time";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addPatientBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 636);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 45);
            this.panel1.TabIndex = 0;
            // 
            // addPatientBTN
            // 
            this.addPatientBTN.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.addPatientBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.addPatientBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addPatientBTN.BorderRadius = 0;
            this.addPatientBTN.ButtonText = "Send to Operations";
            this.addPatientBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPatientBTN.DisabledColor = System.Drawing.Color.Gray;
            this.addPatientBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.addPatientBTN.Font = new System.Drawing.Font("Nunito", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientBTN.Iconcolor = System.Drawing.Color.Transparent;
            this.addPatientBTN.Iconimage = ((System.Drawing.Image)(resources.GetObject("addPatientBTN.Iconimage")));
            this.addPatientBTN.Iconimage_right = null;
            this.addPatientBTN.Iconimage_right_Selected = null;
            this.addPatientBTN.Iconimage_Selected = null;
            this.addPatientBTN.IconMarginLeft = 0;
            this.addPatientBTN.IconMarginRight = 0;
            this.addPatientBTN.IconRightVisible = true;
            this.addPatientBTN.IconRightZoom = 0D;
            this.addPatientBTN.IconVisible = true;
            this.addPatientBTN.IconZoom = 90D;
            this.addPatientBTN.IsTab = false;
            this.addPatientBTN.Location = new System.Drawing.Point(733, 0);
            this.addPatientBTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addPatientBTN.Name = "addPatientBTN";
            this.addPatientBTN.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.addPatientBTN.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.addPatientBTN.OnHoverTextColor = System.Drawing.Color.White;
            this.addPatientBTN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addPatientBTN.selected = false;
            this.addPatientBTN.Size = new System.Drawing.Size(250, 45);
            this.addPatientBTN.TabIndex = 9;
            this.addPatientBTN.Text = "Send to Operations";
            this.addPatientBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addPatientBTN.Textcolor = System.Drawing.Color.White;
            this.addPatientBTN.TextFont = new System.Drawing.Font("Nunito", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.bunifuCustomLabel10);
            this.topPanel.Controls.Add(this.panel3);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(30, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(983, 94);
            this.topPanel.TabIndex = 6;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(17, 25);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(134, 38);
            this.bunifuCustomLabel10.TabIndex = 4;
            this.bunifuCustomLabel10.Text = "Tests List";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuTextbox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(607, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 94);
            this.panel3.TabIndex = 3;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.White;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(24, 25);
            this.bunifuTextbox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(345, 48);
            this.bunifuTextbox1.TabIndex = 0;
            this.bunifuTextbox1.text = "Search";
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(30, 775);
            this.leftPanel.TabIndex = 9;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1013, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(30, 775);
            this.rightPanel.TabIndex = 8;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 775);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1043, 30);
            this.BottomPanel.TabIndex = 7;
            // 
            // TestsListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.BottomPanel);
            this.Font = new System.Drawing.Font("Nunito", 8F);
            this.Name = "TestsListControl";
            this.Size = new System.Drawing.Size(1043, 805);
            this.Load += new System.EventHandler(this.TestsListControl_Load);
            this.containerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTests)).EndInit();
            this.panel1.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel topPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton addPatientBTN;
    }
}
