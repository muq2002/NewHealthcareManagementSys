namespace HealthcareManagementSystem.UserControls.Registration
{
    partial class RegistrationPatientListControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationPatientListControl));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.paddingPanel = new System.Windows.Forms.Panel();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.dataPatients = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topPanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchPatientText = new Bunifu.Framework.UI.BunifuTextbox();
            this.widgetsPanel = new System.Windows.Forms.Panel();
            this.widget1 = new HealthcareManagementSystem.CurvedPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalNumberPatientsLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPatients)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.widgetsPanel.SuspendLayout();
            this.widget1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 85);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(30, 597);
            this.leftPanel.TabIndex = 15;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1013, 85);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(30, 597);
            this.rightPanel.TabIndex = 14;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 682);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1043, 27);
            this.BottomPanel.TabIndex = 13;
            // 
            // paddingPanel
            // 
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.paddingPanel.Location = new System.Drawing.Point(300, 0);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Size = new System.Drawing.Size(40, 177);
            this.paddingPanel.TabIndex = 4;
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.dataPatients);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerPanel.Location = new System.Drawing.Point(0, 85);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1043, 624);
            this.containerPanel.TabIndex = 17;
            // 
            // dataPatients
            // 
            this.dataPatients.AllowUserToAddRows = false;
            this.dataPatients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataPatients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5});
            this.dataPatients.ContextMenuStrip = this.contextMenuStrip1;
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
            this.dataPatients.Size = new System.Drawing.Size(1043, 624);
            this.dataPatients.TabIndex = 4;
            // 
            // _id
            // 
            this._id.HeaderText = "Column8";
            this._id.Name = "_id";
            this._id.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
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
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gender";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Phone Number";
            this.Column7.Name = "Column7";
            this.Column7.Width = 180;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            this.Column5.Width = 220;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.editToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 94);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.Image")));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateToolStripMenuItem.Image")));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.updateToolStripMenuItem.Text = "Delete";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.bunifuCustomLabel10);
            this.topPanel.Controls.Add(this.panel3);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1043, 85);
            this.topPanel.TabIndex = 12;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(38, 23);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(170, 38);
            this.bunifuCustomLabel10.TabIndex = 4;
            this.bunifuCustomLabel10.Text = "Patients List";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.searchPatientText);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(649, 0);
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
            // widgetsPanel
            // 
            this.widgetsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.widgetsPanel.Controls.Add(this.paddingPanel);
            this.widgetsPanel.Controls.Add(this.widget1);
            this.widgetsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.widgetsPanel.Location = new System.Drawing.Point(0, 709);
            this.widgetsPanel.Name = "widgetsPanel";
            this.widgetsPanel.Size = new System.Drawing.Size(1043, 177);
            this.widgetsPanel.TabIndex = 16;
            // 
            // widget1
            // 
            this.widget1.BackColor = System.Drawing.Color.White;
            this.widget1.Controls.Add(this.panel2);
            this.widget1.Controls.Add(this.panel11);
            this.widget1.Dock = System.Windows.Forms.DockStyle.Left;
            this.widget1.Location = new System.Drawing.Point(0, 0);
            this.widget1.Name = "widget1";
            this.widget1.Size = new System.Drawing.Size(300, 177);
            this.widget1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.totalNumberPatientsLabel);
            this.panel2.Controls.Add(this.dateLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 104);
            this.panel2.TabIndex = 9;
            // 
            // totalNumberPatientsLabel
            // 
            this.totalNumberPatientsLabel.AutoSize = true;
            this.totalNumberPatientsLabel.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNumberPatientsLabel.ForeColor = System.Drawing.Color.Black;
            this.totalNumberPatientsLabel.Location = new System.Drawing.Point(133, 3);
            this.totalNumberPatientsLabel.Name = "totalNumberPatientsLabel";
            this.totalNumberPatientsLabel.Size = new System.Drawing.Size(44, 50);
            this.totalNumberPatientsLabel.TabIndex = 13;
            this.totalNumberPatientsLabel.Text = "0";
            // 
            // dateLabel1
            // 
            this.dateLabel1.AutoSize = true;
            this.dateLabel1.Font = new System.Drawing.Font("Nunito", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel1.ForeColor = System.Drawing.Color.Black;
            this.dateLabel1.Location = new System.Drawing.Point(34, 60);
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Size = new System.Drawing.Size(233, 28);
            this.dateLabel1.TabIndex = 12;
            this.dateLabel1.Text = "Friday, February 9, 2024";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.bunifuCustomLabel3);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(300, 73);
            this.panel11.TabIndex = 8;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Nunito", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(37, 14);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(227, 44);
            this.bunifuCustomLabel3.TabIndex = 1;
            this.bunifuCustomLabel3.Text = "Total Patients";
            // 
            // RegistrationPatientListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.widgetsPanel);
            this.Font = new System.Drawing.Font("Nunito", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RegistrationPatientListControl";
            this.Size = new System.Drawing.Size(1043, 886);
            this.Load += new System.EventHandler(this.RegistrationPatientListControl_Load);
            this.containerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPatients)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.widgetsPanel.ResumeLayout(false);
            this.widget1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CurvedPanel widget1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel totalNumberPatientsLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel dateLabel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel paddingPanel;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel topPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuTextbox searchPatientText;
        private System.Windows.Forms.Panel widgetsPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        protected Bunifu.Framework.UI.BunifuCustomDataGrid dataPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
