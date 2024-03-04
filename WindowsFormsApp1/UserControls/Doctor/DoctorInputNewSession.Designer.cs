namespace HealthcareManagement.UserControls.Doctor
{
    partial class DoctorInputNewSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorInputNewSession));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.createSessionBTN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.textSession = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.bunifuCards1.Controls.Add(this.createSessionBTN);
            this.bunifuCards1.Controls.Add(this.panel1);
            this.bunifuCards1.Controls.Add(this.textSession);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(365, 175);
            this.bunifuCards1.TabIndex = 8;
            // 
            // createSessionBTN
            // 
            this.createSessionBTN.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.createSessionBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.createSessionBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createSessionBTN.BorderRadius = 0;
            this.createSessionBTN.ButtonText = "Create Session";
            this.createSessionBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createSessionBTN.DisabledColor = System.Drawing.Color.Gray;
            this.createSessionBTN.Iconcolor = System.Drawing.Color.Transparent;
            this.createSessionBTN.Iconimage = ((System.Drawing.Image)(resources.GetObject("createSessionBTN.Iconimage")));
            this.createSessionBTN.Iconimage_right = null;
            this.createSessionBTN.Iconimage_right_Selected = null;
            this.createSessionBTN.Iconimage_Selected = null;
            this.createSessionBTN.IconMarginLeft = 0;
            this.createSessionBTN.IconMarginRight = 0;
            this.createSessionBTN.IconRightVisible = true;
            this.createSessionBTN.IconRightZoom = 0D;
            this.createSessionBTN.IconVisible = true;
            this.createSessionBTN.IconZoom = 90D;
            this.createSessionBTN.IsTab = false;
            this.createSessionBTN.Location = new System.Drawing.Point(52, 128);
            this.createSessionBTN.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.createSessionBTN.Name = "createSessionBTN";
            this.createSessionBTN.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.createSessionBTN.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.createSessionBTN.OnHoverTextColor = System.Drawing.Color.White;
            this.createSessionBTN.selected = false;
            this.createSessionBTN.Size = new System.Drawing.Size(236, 37);
            this.createSessionBTN.TabIndex = 17;
            this.createSessionBTN.Text = "Create Session";
            this.createSessionBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createSessionBTN.Textcolor = System.Drawing.Color.White;
            this.createSessionBTN.TextFont = new System.Drawing.Font("Nunito", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSessionBTN.Click += new System.EventHandler(this.createSessionBTN_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 31);
            this.panel1.TabIndex = 16;
            // 
            // picClose
            // 
            this.picClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("picClose.InitialImage")));
            this.picClose.Location = new System.Drawing.Point(328, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(35, 31);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 16;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // textSession
            // 
            this.textSession.Location = new System.Drawing.Point(12, 76);
            this.textSession.Name = "textSession";
            this.textSession.Size = new System.Drawing.Size(331, 40);
            this.textSession.TabIndex = 13;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(85, 40);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(171, 33);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Session Name";
            // 
            // DoctorInputNewSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 175);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DoctorInputNewSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Input New Session";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.TextBox textSession;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton createSessionBTN;
    }
}