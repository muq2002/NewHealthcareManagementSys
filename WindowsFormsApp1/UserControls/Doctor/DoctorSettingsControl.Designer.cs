namespace HealthcareManagement.UserControls.Doctor
{
    partial class DoctorSettingsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorSettingsControl));
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPatients = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveDevicesBTN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBaudRate = new System.Windows.Forms.ComboBox();
            this.comboPortName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textYourDeviceIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPharmcyIP = new System.Windows.Forms.Label();
            this.textLabIP = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.topPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataPatients)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.containerPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            this.Column5.Width = 220;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gender";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Age";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // _id
            // 
            this._id.HeaderText = "Column8";
            this._id.Name = "_id";
            this._id.Visible = false;
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
            this.dataPatients.Location = new System.Drawing.Point(3, 3);
            this.dataPatients.Name = "dataPatients";
            this.dataPatients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataPatients.RowHeadersWidth = 40;
            this.dataPatients.RowTemplate.Height = 28;
            this.dataPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPatients.Size = new System.Drawing.Size(999, 636);
            this.dataPatients.TabIndex = 4;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Phone Number";
            this.Column7.Name = "Column7";
            this.Column7.Width = 180;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.restoreToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 64);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.Image")));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(151, 30);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restoreToolStripMenuItem.Image")));
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(151, 30);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataPatients);
            this.tabPage2.Location = new System.Drawing.Point(4, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1005, 642);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recycle Bin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1005, 642);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(999, 279);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Accounts Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 38);
            this.label5.TabIndex = 12;
            this.label5.Text = "Version";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(323, 97);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(421, 46);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "1.0.2";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(323, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(421, 46);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "HMS For Doctors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Software Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 46);
            this.textBox1.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(317, 148);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(421, 46);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "doc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveDevicesBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 599);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 40);
            this.panel1.TabIndex = 3;
            // 
            // saveDevicesBTN
            // 
            this.saveDevicesBTN.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.saveDevicesBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.saveDevicesBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveDevicesBTN.BorderRadius = 0;
            this.saveDevicesBTN.ButtonText = "Save";
            this.saveDevicesBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveDevicesBTN.DisabledColor = System.Drawing.Color.Gray;
            this.saveDevicesBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveDevicesBTN.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDevicesBTN.Iconcolor = System.Drawing.Color.Transparent;
            this.saveDevicesBTN.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveDevicesBTN.Iconimage")));
            this.saveDevicesBTN.Iconimage_right = null;
            this.saveDevicesBTN.Iconimage_right_Selected = null;
            this.saveDevicesBTN.Iconimage_Selected = null;
            this.saveDevicesBTN.IconMarginLeft = 0;
            this.saveDevicesBTN.IconMarginRight = 0;
            this.saveDevicesBTN.IconRightVisible = true;
            this.saveDevicesBTN.IconRightZoom = 0D;
            this.saveDevicesBTN.IconVisible = true;
            this.saveDevicesBTN.IconZoom = 90D;
            this.saveDevicesBTN.IsTab = false;
            this.saveDevicesBTN.Location = new System.Drawing.Point(789, 0);
            this.saveDevicesBTN.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.saveDevicesBTN.Name = "saveDevicesBTN";
            this.saveDevicesBTN.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.saveDevicesBTN.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.saveDevicesBTN.OnHoverTextColor = System.Drawing.Color.White;
            this.saveDevicesBTN.selected = false;
            this.saveDevicesBTN.Size = new System.Drawing.Size(210, 40);
            this.saveDevicesBTN.TabIndex = 9;
            this.saveDevicesBTN.Text = "Save";
            this.saveDevicesBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveDevicesBTN.Textcolor = System.Drawing.Color.White;
            this.saveDevicesBTN.TextFont = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBaudRate);
            this.groupBox1.Controls.Add(this.comboPortName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textYourDeviceIP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textPharmcyIP);
            this.groupBox1.Controls.Add(this.textLabIP);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connections and Network";
            // 
            // comboBaudRate
            // 
            this.comboBaudRate.FormattingEnabled = true;
            this.comboBaudRate.Items.AddRange(new object[] {
            "9600 ",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.comboBaudRate.Location = new System.Drawing.Point(312, 95);
            this.comboBaudRate.Name = "comboBaudRate";
            this.comboBaudRate.Size = new System.Drawing.Size(426, 46);
            this.comboBaudRate.TabIndex = 17;
            this.comboBaudRate.Text = "9600 ";
            this.comboBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBaudRate_SelectedIndexChanged);
            // 
            // comboPortName
            // 
            this.comboPortName.FormattingEnabled = true;
            this.comboPortName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11"});
            this.comboPortName.Location = new System.Drawing.Point(312, 43);
            this.comboPortName.Name = "comboPortName";
            this.comboPortName.Size = new System.Drawing.Size(426, 46);
            this.comboPortName.TabIndex = 16;
            this.comboPortName.Text = "COM4";
            this.comboPortName.SelectedIndexChanged += new System.EventHandler(this.comboPortName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 38);
            this.label7.TabIndex = 15;
            this.label7.Text = "Port Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 38);
            this.label6.TabIndex = 14;
            this.label6.Text = "Baud Rate:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(317, 257);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(421, 46);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "60.90.00.03";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(317, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(421, 46);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "60.90.00.02";
            // 
            // textYourDeviceIP
            // 
            this.textYourDeviceIP.Location = new System.Drawing.Point(317, 153);
            this.textYourDeviceIP.Name = "textYourDeviceIP";
            this.textYourDeviceIP.Size = new System.Drawing.Size(421, 46);
            this.textYourDeviceIP.TabIndex = 3;
            this.textYourDeviceIP.Text = "60.90.00.01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your device";
            // 
            // textPharmcyIP
            // 
            this.textPharmcyIP.AutoSize = true;
            this.textPharmcyIP.Location = new System.Drawing.Point(28, 265);
            this.textPharmcyIP.Name = "textPharmcyIP";
            this.textPharmcyIP.Size = new System.Drawing.Size(230, 38);
            this.textPharmcyIP.TabIndex = 1;
            this.textPharmcyIP.Text = "Send Pharmcy IP";
            // 
            // textLabIP
            // 
            this.textLabIP.AutoSize = true;
            this.textLabIP.Location = new System.Drawing.Point(28, 213);
            this.textLabIP.Name = "textLabIP";
            this.textLabIP.Size = new System.Drawing.Size(166, 38);
            this.textLabIP.TabIndex = 0;
            this.textLabIP.Text = "Send Lab IP";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1013, 693);
            this.tabControl1.TabIndex = 0;
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.tabControl1);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerPanel.Location = new System.Drawing.Point(30, 85);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1013, 693);
            this.containerPanel.TabIndex = 33;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 85);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(30, 693);
            this.leftPanel.TabIndex = 32;
            // 
            // rightPanel
            // 
            this.rightPanel.Location = new System.Drawing.Point(1013, 85);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(30, 693);
            this.rightPanel.TabIndex = 31;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 778);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1043, 27);
            this.BottomPanel.TabIndex = 30;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(36, 29);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(365, 38);
            this.bunifuCustomLabel10.TabIndex = 4;
            this.bunifuCustomLabel10.Text = "Settings And Managements";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.bunifuCustomLabel10);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1043, 85);
            this.topPanel.TabIndex = 29;
            // 
            // DoctorSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Nunito", 8F);
            this.Name = "DoctorSettingsControl";
            this.Size = new System.Drawing.Size(1043, 805);
            this.Load += new System.EventHandler(this.DoctorSettingsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPatients)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.containerPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textYourDeviceIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textPharmcyIP;
        private System.Windows.Forms.Label textLabIP;
        private Bunifu.Framework.UI.BunifuFlatButton saveDevicesBTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBaudRate;
        private System.Windows.Forms.ComboBox comboPortName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
