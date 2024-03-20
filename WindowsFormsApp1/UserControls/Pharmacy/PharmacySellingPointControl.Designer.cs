namespace HealthcareManagement.UserControls.Pharmacy
{
    partial class PharmacySellingPointControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacySellingPointControl));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataDrugs = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.paymentBTN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textRequestPrice = new System.Windows.Forms.TextBox();
            this.textPayOffPrice = new System.Windows.Forms.TextBox();
            this.textTotalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.summaryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.bunifuCards1.SuspendLayout();
            this.containerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDrugs)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summaryChart)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards1.Controls.Add(this.containerPanel);
            this.bunifuCards1.Controls.Add(this.panel2);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1043, 727);
            this.bunifuCards1.TabIndex = 10;
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.panel1);
            this.containerPanel.Controls.Add(this.panel3);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerPanel.Location = new System.Drawing.Point(0, 21);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1041, 704);
            this.containerPanel.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataDrugs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 704);
            this.panel1.TabIndex = 2;
            // 
            // dataDrugs
            // 
            this.dataDrugs.AllowUserToAddRows = false;
            this.dataDrugs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataDrugs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataDrugs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataDrugs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDrugs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDrugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5});
            this.dataDrugs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDrugs.DoubleBuffered = true;
            this.dataDrugs.EnableHeadersVisualStyles = false;
            this.dataDrugs.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.dataDrugs.HeaderForeColor = System.Drawing.Color.White;
            this.dataDrugs.Location = new System.Drawing.Point(0, 0);
            this.dataDrugs.Name = "dataDrugs";
            this.dataDrugs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataDrugs.RowHeadersWidth = 40;
            this.dataDrugs.RowTemplate.Height = 28;
            this.dataDrugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDrugs.Size = new System.Drawing.Size(658, 704);
            this.dataDrugs.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Medicine Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 280;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qty";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Instructions";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(658, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 704);
            this.panel3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.paymentBTN);
            this.groupBox2.Controls.Add(this.textRequestPrice);
            this.groupBox2.Controls.Add(this.textPayOffPrice);
            this.groupBox2.Controls.Add(this.textTotalPrice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 343);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            // 
            // paymentBTN
            // 
            this.paymentBTN.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.paymentBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.paymentBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paymentBTN.BorderRadius = 0;
            this.paymentBTN.ButtonText = "Pay and Register";
            this.paymentBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paymentBTN.DisabledColor = System.Drawing.Color.Gray;
            this.paymentBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paymentBTN.Font = new System.Drawing.Font("Nunito", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentBTN.Iconcolor = System.Drawing.Color.Transparent;
            this.paymentBTN.Iconimage = ((System.Drawing.Image)(resources.GetObject("paymentBTN.Iconimage")));
            this.paymentBTN.Iconimage_right = null;
            this.paymentBTN.Iconimage_right_Selected = null;
            this.paymentBTN.Iconimage_Selected = null;
            this.paymentBTN.IconMarginLeft = 0;
            this.paymentBTN.IconMarginRight = 0;
            this.paymentBTN.IconRightVisible = true;
            this.paymentBTN.IconRightZoom = 0D;
            this.paymentBTN.IconVisible = true;
            this.paymentBTN.IconZoom = 90D;
            this.paymentBTN.IsTab = false;
            this.paymentBTN.Location = new System.Drawing.Point(3, 288);
            this.paymentBTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.paymentBTN.Name = "paymentBTN";
            this.paymentBTN.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.paymentBTN.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.paymentBTN.OnHoverTextColor = System.Drawing.Color.White;
            this.paymentBTN.selected = false;
            this.paymentBTN.Size = new System.Drawing.Size(377, 52);
            this.paymentBTN.TabIndex = 9;
            this.paymentBTN.Text = "Pay and Register";
            this.paymentBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paymentBTN.Textcolor = System.Drawing.Color.White;
            this.paymentBTN.TextFont = new System.Drawing.Font("Nunito", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // textRequestPrice
            // 
            this.textRequestPrice.Location = new System.Drawing.Point(156, 144);
            this.textRequestPrice.Name = "textRequestPrice";
            this.textRequestPrice.ReadOnly = true;
            this.textRequestPrice.Size = new System.Drawing.Size(191, 46);
            this.textRequestPrice.TabIndex = 5;
            this.textRequestPrice.Text = "0";
            // 
            // textPayOffPrice
            // 
            this.textPayOffPrice.Location = new System.Drawing.Point(156, 92);
            this.textPayOffPrice.Name = "textPayOffPrice";
            this.textPayOffPrice.Size = new System.Drawing.Size(191, 46);
            this.textPayOffPrice.TabIndex = 4;
            this.textPayOffPrice.Text = "0";
            this.textPayOffPrice.TextChanged += new System.EventHandler(this.textPayOffPrice_TextChanged);
            // 
            // textTotalPrice
            // 
            this.textTotalPrice.Location = new System.Drawing.Point(156, 40);
            this.textTotalPrice.Name = "textTotalPrice";
            this.textTotalPrice.ReadOnly = true;
            this.textTotalPrice.Size = new System.Drawing.Size(191, 46);
            this.textTotalPrice.TabIndex = 3;
            this.textTotalPrice.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Request";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "PayOff";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.summaryChart);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // summaryChart
            // 
            chartArea2.Name = "ChartArea1";
            this.summaryChart.ChartAreas.Add(chartArea2);
            this.summaryChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.summaryChart.Legends.Add(legend2);
            this.summaryChart.Location = new System.Drawing.Point(3, 42);
            this.summaryChart.Name = "summaryChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.summaryChart.Series.Add(series2);
            this.summaryChart.Size = new System.Drawing.Size(377, 316);
            this.summaryChart.TabIndex = 0;
            this.summaryChart.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1041, 21);
            this.panel2.TabIndex = 23;
            // 
            // picClose
            // 
            this.picClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("picClose.InitialImage")));
            this.picClose.Location = new System.Drawing.Point(1006, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(35, 21);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 17;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // PharmacySellingPointControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1043, 727);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Nunito", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PharmacySellingPointControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pharmacySellingPointControl";
            this.Load += new System.EventHandler(this.PharmacySellingPointControl_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.containerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDrugs)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.summaryChart)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataDrugs;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textRequestPrice;
        private System.Windows.Forms.TextBox textPayOffPrice;
        private System.Windows.Forms.TextBox textTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart summaryChart;
        private Bunifu.Framework.UI.BunifuFlatButton paymentBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}