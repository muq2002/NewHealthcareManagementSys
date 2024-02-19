using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.UserControls.Doctor;

namespace WindowsFormsApp1.UserControls.Registration
{
    public partial class RegistrationHomeControl : UserControl
    {
        public RegistrationHomeControl()
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
