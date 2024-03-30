namespace HealthcareManagement.Screens.Screens
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
            this.registrationHomeControl2 = new HealthcareManagement.Screens.UserControls.Registration.RegistrationHomeControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.Panel();
            this.item1 = new System.Windows.Forms.Panel();
            this.RegistrationBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.helpBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.patientBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.settingsBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel5 = new System.Windows.Forms.Panel();
            this.logoutBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.container.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.sidebar.SuspendLayout();
            this.item1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.registrationHomeControl2);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(300, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(876, 648);
            this.container.TabIndex = 3;
            // 
            // registrationHomeControl2
            // 
            this.registrationHomeControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.registrationHomeControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrationHomeControl2.Font = new System.Drawing.Font("Nunito", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationHomeControl2.Location = new System.Drawing.Point(0, 0);
            this.registrationHomeControl2.Name = "registrationHomeControl2";
            this.registrationHomeControl2.Size = new System.Drawing.Size(876, 648);
            this.registrationHomeControl2.TabIndex = 0;
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
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.item1);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(300, 648);
            this.sidebar.TabIndex = 2;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.patientBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 70);
            this.panel1.TabIndex = 8;
            // 
            // patientBTN
            // 
            this.patientBTN.ActiveBorderThickness = 1;
            this.patientBTN.ActiveCornerRadius = 20;
            this.patientBTN.ActiveFillColor = System.Drawing.Color.White;
            this.patientBTN.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.patientBTN.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
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
            this.patientBTN.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.patientBTN.Name = "patientBTN";
            this.patientBTN.Size = new System.Drawing.Size(300, 70);
            this.patientBTN.TabIndex = 1;
            this.patientBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.patientBTN.Click += new System.EventHandler(this.patientBTN_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.settingsBTN);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 70);
            this.panel3.TabIndex = 9;
            // 
            // settingsBTN
            // 
            this.settingsBTN.ActiveBorderThickness = 1;
            this.settingsBTN.ActiveCornerRadius = 20;
            this.settingsBTN.ActiveFillColor = System.Drawing.Color.White;
            this.settingsBTN.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.settingsBTN.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.settingsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.settingsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsBTN.BackgroundImage")));
            this.settingsBTN.ButtonText = "Setttings";
            this.settingsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsBTN.Font = new System.Drawing.Font("Nunito ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBTN.ForeColor = System.Drawing.Color.White;
            this.settingsBTN.IdleBorderThickness = 1;
            this.settingsBTN.IdleCornerRadius = 20;
            this.settingsBTN.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.settingsBTN.IdleForecolor = System.Drawing.Color.White;
            this.settingsBTN.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.settingsBTN.Location = new System.Drawing.Point(0, 0);
            this.settingsBTN.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.settingsBTN.Name = "settingsBTN";
            this.settingsBTN.Size = new System.Drawing.Size(300, 70);
            this.settingsBTN.TabIndex = 1;
            this.settingsBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsBTN.Click += new System.EventHandler(this.SettingsBTN_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.logoutBTN);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 398);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 70);
            this.panel5.TabIndex = 10;
            // 
            // logoutBTN
            // 
            this.logoutBTN.ActiveBorderThickness = 1;
            this.logoutBTN.ActiveCornerRadius = 20;
            this.logoutBTN.ActiveFillColor = System.Drawing.Color.White;
            this.logoutBTN.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.logoutBTN.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
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
            this.logoutBTN.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.logoutBTN.Name = "logoutBTN";
            this.logoutBTN.Size = new System.Drawing.Size(300, 70);
            this.logoutBTN.TabIndex = 1;
            this.logoutBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutBTN.Click += new System.EventHandler(this.logoutBTN_Click);
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
            this.sidebar.ResumeLayout(false);
            this.item1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Panel sidebar;
        private UserControls.Registration.RegistrationHomeControl registrationHomeControl1;
        private UserControls.Registration.RegistrationHomeControl registrationHomeControl2;
        private System.Windows.Forms.Panel item1;
        private Bunifu.Framework.UI.BunifuThinButton2 RegistrationBTN;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuThinButton2 logoutBTN;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 settingsBTN;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 patientBTN;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 helpBTN;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
    }
}