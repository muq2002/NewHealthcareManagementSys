namespace HealthcareManagement.Screens.OperationsLab
{
    partial class OpenCSVFile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboColumns = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SendBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboColumns);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SendBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 39);
            this.panel1.TabIndex = 0;
            // 
            // comboColumns
            // 
            this.comboColumns.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboColumns.FormattingEnabled = true;
            this.comboColumns.Location = new System.Drawing.Point(120, 0);
            this.comboColumns.Name = "comboColumns";
            this.comboColumns.Size = new System.Drawing.Size(121, 28);
            this.comboColumns.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Columns";
            // 
            // SendBTN
            // 
            this.SendBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.SendBTN.Location = new System.Drawing.Point(711, 0);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Size = new System.Drawing.Size(89, 39);
            this.SendBTN.TabIndex = 0;
            this.SendBTN.Text = "Register";
            this.SendBTN.UseVisualStyleBackColor = true;
            this.SendBTN.Click += new System.EventHandler(this.SendBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 411);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            // 
            // OpenCSVFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "OpenCSVFile";
            this.Text = "OpenCSVFile";
            this.Load += new System.EventHandler(this.OpenCSVFile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SendBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboColumns;
        private System.Windows.Forms.Label label1;
    }
}