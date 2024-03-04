using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareManagement.UserControls.Doctor;

namespace HealthcareManagementSystem.UserControls.Doctor
{
    public partial class PatientProfileControl : UserControl
    {
        public PatientProfileControl()
        {
            InitializeComponent();
        }
        public int patientId = 0;
        private void PatientProfileControl_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void openMedicalTests_Click(object sender, EventArgs e)
        {
            DoctorSelectMedicalTests doctorSelectMedicalTests = new DoctorSelectMedicalTests();
            doctorSelectMedicalTests.ShowDialog();
        }
    }
}
