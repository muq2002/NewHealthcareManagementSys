﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UserControls.Doctor
{
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
        {
            InitializeComponent();
        }

        private void addPatientBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
