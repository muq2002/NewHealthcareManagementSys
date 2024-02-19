namespace WindowsFormsApp1.Screens
{
    partial class RegistrationHomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationHomeScreen));
            this.container = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.RegistrationBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.item1 = new System.Windows.Forms.Panel();
            this.patientBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SettingsBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel8 = new System.Windows.Forms.Panel();
            this.bunifuThinButton28 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.logoutBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton210 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel9 = new System.Windows.Forms.Panel();
            this.helpBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.registrationHomeControl1 = new WindowsFormsApp1.UserControls.Registration.RegistrationHomeControl();
            this.container.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.item1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.registrationHomeControl1);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(300, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(876, 648);
            this.container.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.logoPicture);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 188);
            this.panel4.TabIndex = 0;
            // 
            // logoPicture
            // 
            this.logoPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPicture.Image = ((System.Drawing.Image)(resources.GetObject("logoPicture.Image")));
            this.logoPicture.Location = new System.Drawing.Point(0, 0);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(300, 188);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            // 
            // RegistrationBTN
            // 
            this.RegistrationBTN.ActiveBorderThickness = 1;
            this.RegistrationBTN.ActiveCornerRadius = 20;
            this.RegistrationBTN.ActiveFillColor = System.Drawing.Color.White;
            this.RegistrationBTN.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.RegistrationBTN.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.RegistrationBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.RegistrationBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegistrationBTN.BackgroundImage")));
            this.RegistrationBTN.ButtonText = "Registrations";
            this.RegistrationBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegistrationBTN.Font = new System.Drawing.Font("Nunito ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationBTN.ForeColor = System.Drawing.Color.White;
            this.RegistrationBTN.IdleBorderThickness = 1;
            this.RegistrationBTN.IdleCornerRadius = 20;
            this.RegistrationBTN.IdleFillColor = System.Drawing.Color.White;
            this.RegistrationBTN.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.RegistrationBTN.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.RegistrationBTN.Location = new System.Drawing.Point(0, 0);
            this.RegistrationBTN.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.RegistrationBTN.Name = "RegistrationBTN";
            this.RegistrationBTN.Size = new System.Drawing.Size(300, 70);
            this.RegistrationBTN.TabIndex = 1;
            this.RegistrationBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegistrationBTN.Click += new System.EventHandler(this.RegistrationBTN_Click);
            // 
            // item1
            // 
            this.item1.Controls.Add(this.RegistrationBTN);
            this.item1.Dock = System.Windows.Forms.DockStyle.Top;
            this.item1.Location = new System.Drawing.Point(0, 188);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(300, 70);
            this.item1.TabIndex = 1;
            // 
            // patientBTN
            // 
            this.patientBTN.ActiveBorderThickness = 1;
            this.patientBTN.ActiveCornerRadius = 20;
            this.patientBTN.ActiveFillColor = System.Drawing.Color.White;
            this.patientBTN.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.patientBTN.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.patientBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.patientBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("patientBTN.BackgroundImage")));
            this.patientBTN.ButtonText = "Patients";
            this.patientBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientBTN.Font = new System.Drawing.Font("Nunito ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientBTN.ForeColor = System.Drawing.Color.White;
            this.patientBTN.IdleBorderThickness = 1;
            this.patientBTN.IdleCornerRadius = 20;
            this.patientBTN.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.patientBTN.IdleForecolor = System.Drawing.Color.White;
            this.patientBTN.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.patientBTN.Location = new System.Drawing.Point(0, 0);
            this.patientBTN.Margin = new System.Windows.Forms.Padding(5);
            this.patientBTN.Name = "patientBTN";
            this.patientBTN.Size = new System.Drawing.Size(300, 70);
            this.patientBTN.TabIndex = 1;
            this.patientBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.patientBTN.Click += new System.EventHandler(this.patientBTN_Click);

            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.patientBTN);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 258);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 70);
            this.panel5.TabIndex = 2;
            // 
            // SettingsBTN
            // 
            this.SettingsBTN.ActiveBorderThickness = 1;
            this.SettingsBTN.ActiveCornerRadius = 20;
            this.SettingsBTN.ActiveFillColor = System.Drawing.Color.White;
            this.SettingsBTN.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.SettingsBTN.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.SettingsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.SettingsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsBTN.BackgroundImage")));
            this.SettingsBTN.ButtonText = "Settings";
            this.SettingsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsBTN.Font = new System.Drawing.Font("Nunito ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBTN.ForeColor = System.Drawing.Color.White;
            this.SettingsBTN.IdleBorderThickness = 1;
            this.SettingsBTN.IdleCornerRadius = 20;
            this.SettingsBTN.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.SettingsBTN.IdleForecolor = System.Drawing.Color.White;
            this.SettingsBTN.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.SettingsBTN.Location = new System.Drawing.Point(0, 0);
            this.SettingsBTN.Margin = new System.Windows.Forms.Padding(5);
            this.SettingsBTN.Name = "SettingsBTN";
            this.SettingsBTN.Size = new System.Drawing.Size(300, 70);
            this.SettingsBTN.TabIndex = 2;
            this.SettingsBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.SettingsBTN);
            this.panel8.Controls.Add(this.bunifuThinButton28);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 328);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(300, 70);
            this.panel8.TabIndex = 5;
            // 
            // bunifuThinButton28
            // 
            this.bunifuThinButton28.ActiveBorderThickness = 1;
            this.bunifuThinButton28.ActiveCornerRadius = 20;
            this.bunifuThinButton28.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton28.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.bunifuThinButton28.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.bunifuThinButton28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton28.BackgroundImage")));
            this.bunifuThinButton28.ButtonText = "Statistics";
            this.bunifuThinButton28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuThinButton28.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton28.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton28.IdleBorderThickness = 1;
            this.bunifuThinButton28.IdleCornerRadius = 20;
            this.bunifuThinButton28.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.bunifuThinButton28.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton28.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.bunifuThinButton28.Location = new System.Drawing.Point(0, 0);
            this.bunifuThinButton28.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton28.Name = "bunifuThinButton28";
            this.bunifuThinButton28.Size = new System.Drawing.Size(300, 70);
            this.bunifuThinButton28.TabIndex = 1;
            this.bunifuThinButton28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutBTN
            // 
            this.logoutBTN.ActiveBorderThickness = 1;
            this.logoutBTN.ActiveCornerRadius = 20;
            this.logoutBTN.ActiveFillColor = System.Drawing.Color.White;
            this.logoutBTN.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.logoutBTN.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.logoutBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.logoutBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutBTN.BackgroundImage")));
            this.logoutBTN.ButtonText = "Logout";
            this.logoutBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoutBTN.Font = new System.Drawing.Font("Nunito ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBTN.ForeColor = System.Drawing.Color.White;
            this.logoutBTN.IdleBorderThickness = 1;
            this.logoutBTN.IdleCornerRadius = 20;
            this.logoutBTN.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.logoutBTN.IdleForecolor = System.Drawing.Color.White;
            this.logoutBTN.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.logoutBTN.Location = new System.Drawing.Point(0, 0);
            this.logoutBTN.Margin = new System.Windows.Forms.Padding(5);
            this.logoutBTN.Name = "logoutBTN";
            this.logoutBTN.Size = new System.Drawing.Size(300, 70);
            this.logoutBTN.TabIndex = 2;
            this.logoutBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutBTN.Click += new System.EventHandler(this.logoutBTN_Click);
            // 
            // bunifuThinButton210
            // 
            this.bunifuThinButton210.ActiveBorderThickness = 1;
            this.bunifuThinButton210.ActiveCornerRadius = 20;
            this.bunifuThinButton210.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton210.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.bunifuThinButton210.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton210.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.bunifuThinButton210.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton210.BackgroundImage")));
            this.bunifuThinButton210.ButtonText = "Statistics";
            this.bunifuThinButton210.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton210.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuThinButton210.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton210.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton210.IdleBorderThickness = 1;
            this.bunifuThinButton210.IdleCornerRadius = 20;
            this.bunifuThinButton210.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.bunifuThinButton210.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton210.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.bunifuThinButton210.Location = new System.Drawing.Point(0, 0);
            this.bunifuThinButton210.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton210.Name = "bunifuThinButton210";
            this.bunifuThinButton210.Size = new System.Drawing.Size(300, 70);
            this.bunifuThinButton210.TabIndex = 1;
            this.bunifuThinButton210.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.logoutBTN);
            this.panel9.Controls.Add(this.bunifuThinButton210);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 398);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(300, 70);
            this.panel9.TabIndex = 6;
            // 
            // helpBTN
            // 
            this.helpBTN.ActiveBorderThickness = 1;
            this.helpBTN.ActiveCornerRadius = 20;
            this.helpBTN.ActiveFillColor = System.Drawing.Color.White;
            this.helpBTN.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.helpBTN.ActiveLineColor = System.Drawing.Color.White;
            this.helpBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.helpBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpBTN.BackgroundImage")));
            this.helpBTN.ButtonText = "Help";
            this.helpBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpBTN.Font = new System.Drawing.Font("Nunito ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBTN.ForeColor = System.Drawing.Color.White;
            this.helpBTN.IdleBorderThickness = 1;
            this.helpBTN.IdleCornerRadius = 20;
            this.helpBTN.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.helpBTN.IdleForecolor = System.Drawing.Color.White;
            this.helpBTN.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.helpBTN.Location = new System.Drawing.Point(0, 0);
            this.helpBTN.Margin = new System.Windows.Forms.Padding(5);
            this.helpBTN.Name = "helpBTN";
            this.helpBTN.Size = new System.Drawing.Size(300, 70);
            this.helpBTN.TabIndex = 2;
            this.helpBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Statistics";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(0, 0);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(300, 70);
            this.bunifuThinButton22.TabIndex = 1;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.helpBTN);
            this.panel2.Controls.Add(this.bunifuThinButton22);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 578);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 70);
            this.panel2.TabIndex = 7;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel9);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.item1);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(300, 648);
            this.sidebar.TabIndex = 2;
            // 
            // registrationHomeControl1
            // 
            this.registrationHomeControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.registrationHomeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrationHomeControl1.Font = new System.Drawing.Font("Nunito", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationHomeControl1.Location = new System.Drawing.Point(0, 0);
            this.registrationHomeControl1.Name = "registrationHomeControl1";
            this.registrationHomeControl1.Size = new System.Drawing.Size(876, 648);
            this.registrationHomeControl1.TabIndex = 0;
            // 
            // RegistrationHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 648);
            this.Controls.Add(this.container);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationHomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationHomeScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RegistrationHomeScreen_Load);
            this.container.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.item1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox logoPicture;
        private Bunifu.Framework.UI.BunifuThinButton2 RegistrationBTN;
        private System.Windows.Forms.Panel item1;
        private Bunifu.Framework.UI.BunifuThinButton2 patientBTN;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuThinButton2 SettingsBTN;
        private System.Windows.Forms.Panel panel8;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton28;
        private Bunifu.Framework.UI.BunifuThinButton2 logoutBTN;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton210;
        private System.Windows.Forms.Panel panel9;
        private Bunifu.Framework.UI.BunifuThinButton2 helpBTN;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sidebar;
        private UserControls.Registration.RegistrationHomeControl registrationHomeControl1;
    }
}