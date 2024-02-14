using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UserControls.Doctor
{
    public partial class DoctorHomeControl : UserControl
    {
        public DoctorHomeControl()
        {
            InitializeComponent();
        }

        private void addPatientBTN_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.ShowDialog();
        }
    }
}
