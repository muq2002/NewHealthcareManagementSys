namespace HealthcareManagementSystem.UserControls.Doctor
{
    partial class PatientProfileControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientProfileControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataPrescriptions = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.savePatientBTN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textAutomatedDiagnosis = new System.Windows.Forms.TextBox();
            this.richTextComments = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataTests = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openMedicalTests = new Bunifu.Framework.UI.BunifuFlatButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containerPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrescriptions)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTests)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.tabControl1);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1043, 805);
            this.containerPanel.TabIndex = 22;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1043, 805);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1035, 754);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Prescriptions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataPrescriptions);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1029, 495);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prescription";
            // 
            // dataPrescriptions
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataPrescriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataPrescriptions.BackgroundColor = System.Drawing.Color.White;
            this.dataPrescriptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPrescriptions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPrescriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPrescriptions.ContextMenuStrip = this.contextMenuStrip1;
            this.dataPrescriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPrescriptions.DoubleBuffered = true;
            this.dataPrescriptions.EnableHeadersVisualStyles = false;
            this.dataPrescriptions.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.dataPrescriptions.HeaderForeColor = System.Drawing.Color.White;
            this.dataPrescriptions.Location = new System.Drawing.Point(3, 42);
            this.dataPrescriptions.Name = "dataPrescriptions";
            this.dataPrescriptions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataPrescriptions.RowHeadersWidth = 40;
            this.dataPrescriptions.RowTemplate.Height = 28;
            this.dataPrescriptions.Size = new System.Drawing.Size(1023, 400);
            this.dataPrescriptions.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.savePatientBTN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 50);
            this.panel2.TabIndex = 5;
            // 
            // savePatientBTN
            // 
            this.savePatientBTN.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.savePatientBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.savePatientBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savePatientBTN.BorderRadius = 0;
            this.savePatientBTN.ButtonText = "Send";
            this.savePatientBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePatientBTN.DisabledColor = System.Drawing.Color.Gray;
            this.savePatientBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.savePatientBTN.Font = new System.Drawing.Font("Nunito", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePatientBTN.Iconcolor = System.Drawing.Color.Transparent;
            this.savePatientBTN.Iconimage = ((System.Drawing.Image)(resources.GetObject("savePatientBTN.Iconimage")));
            this.savePatientBTN.Iconimage_right = null;
            this.savePatientBTN.Iconimage_right_Selected = null;
            this.savePatientBTN.Iconimage_Selected = null;
            this.savePatientBTN.IconMarginLeft = 0;
            this.savePatientBTN.IconMarginRight = 0;
            this.savePatientBTN.IconRightVisible = false;
            this.savePatientBTN.IconRightZoom = 0D;
            this.savePatientBTN.IconVisible = false;
            this.savePatientBTN.IconZoom = 90D;
            this.savePatientBTN.IsTab = false;
            this.savePatientBTN.Location = new System.Drawing.Point(814, 0);
            this.savePatientBTN.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.savePatientBTN.Name = "savePatientBTN";
            this.savePatientBTN.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.savePatientBTN.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.savePatientBTN.OnHoverTextColor = System.Drawing.Color.White;
            this.savePatientBTN.selected = false;
            this.savePatientBTN.Size = new System.Drawing.Size(209, 50);
            this.savePatientBTN.TabIndex = 11;
            this.savePatientBTN.Text = "Send";
            this.savePatientBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.savePatientBTN.Textcolor = System.Drawing.Color.White;
            this.savePatientBTN.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePatientBTN.Click += new System.EventHandler(this.savePatientBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textAutomatedDiagnosis);
            this.groupBox1.Controls.Add(this.richTextComments);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1029, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Predications  And Tools";
            // 
            // textAutomatedDiagnosis
            // 
            this.textAutomatedDiagnosis.Location = new System.Drawing.Point(374, 61);
            this.textAutomatedDiagnosis.Name = "textAutomatedDiagnosis";
            this.textAutomatedDiagnosis.Size = new System.Drawing.Size(290, 46);
            this.textAutomatedDiagnosis.TabIndex = 3;
            // 
            // richTextComments
            // 
            this.richTextComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(251)))));
            this.richTextComments.Location = new System.Drawing.Point(13, 145);
            this.richTextComments.Name = "richTextComments";
            this.richTextComments.Size = new System.Drawing.Size(822, 96);
            this.richTextComments.TabIndex = 2;
            this.richTextComments.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comments:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Automated Aid Diagnostic:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dataTests);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1035, 754);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lab Tests";
            // 
            // dataTests
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataTests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTests.BackgroundColor = System.Drawing.Color.White;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column4,
            this.Comments,
            this.Column6,
            this.Column5});
            this.dataTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTests.DoubleBuffered = true;
            this.dataTests.EnableHeadersVisualStyles = false;
            this.dataTests.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.dataTests.HeaderForeColor = System.Drawing.Color.White;
            this.dataTests.Location = new System.Drawing.Point(3, 47);
            this.dataTests.Name = "dataTests";
            this.dataTests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTests.RowHeadersWidth = 40;
            this.dataTests.RowTemplate.Height = 28;
            this.dataTests.Size = new System.Drawing.Size(1029, 704);
            this.dataTests.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tests Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Value";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Normal Value";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            this.Comments.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Register Date";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.openMedicalTests);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 44);
            this.panel1.TabIndex = 0;
            // 
            // openMedicalTests
            // 
            this.openMedicalTests.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.openMedicalTests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.openMedicalTests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openMedicalTests.BorderRadius = 0;
            this.openMedicalTests.ButtonText = "Add new test";
            this.openMedicalTests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openMedicalTests.DisabledColor = System.Drawing.Color.Gray;
            this.openMedicalTests.Dock = System.Windows.Forms.DockStyle.Right;
            this.openMedicalTests.Font = new System.Drawing.Font("Nunito", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openMedicalTests.Iconcolor = System.Drawing.Color.Transparent;
            this.openMedicalTests.Iconimage = ((System.Drawing.Image)(resources.GetObject("openMedicalTests.Iconimage")));
            this.openMedicalTests.Iconimage_right = null;
            this.openMedicalTests.Iconimage_right_Selected = null;
            this.openMedicalTests.Iconimage_Selected = null;
            this.openMedicalTests.IconMarginLeft = 0;
            this.openMedicalTests.IconMarginRight = 0;
            this.openMedicalTests.IconRightVisible = false;
            this.openMedicalTests.IconRightZoom = 0D;
            this.openMedicalTests.IconVisible = false;
            this.openMedicalTests.IconZoom = 90D;
            this.openMedicalTests.IsTab = false;
            this.openMedicalTests.Location = new System.Drawing.Point(820, 0);
            this.openMedicalTests.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.openMedicalTests.Name = "openMedicalTests";
            this.openMedicalTests.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.openMedicalTests.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.openMedicalTests.OnHoverTextColor = System.Drawing.Color.White;
            this.openMedicalTests.selected = false;
            this.openMedicalTests.Size = new System.Drawing.Size(209, 44);
            this.openMedicalTests.TabIndex = 10;
            this.openMedicalTests.Text = "Add new test";
            this.openMedicalTests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openMedicalTests.Textcolor = System.Drawing.Color.White;
            this.openMedicalTests.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openMedicalTests.Click += new System.EventHandler(this.openMedicalTests_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 64);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // PatientProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.containerPanel);
            this.Font = new System.Drawing.Font("Nunito", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PatientProfileControl";
            this.Size = new System.Drawing.Size(1043, 805);
            this.Load += new System.EventHandler(this.PatientProfileControl_Load);
            this.containerPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPrescriptions)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTests)).EndInit();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton openMedicalTests;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton savePatientBTN;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dataTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dataPrescriptions;
        internal System.Windows.Forms.TextBox textAutomatedDiagnosis;
        internal System.Windows.Forms.RichTextBox richTextComments;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}
