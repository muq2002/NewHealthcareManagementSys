using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareManagementSystem.Controller;

namespace HealthcareManagement.UserControls.Lab
{
    public partial class LabPatientProfileControl : UserControl
    {
        public LabPatientProfileControl()
        {
            InitializeComponent();
        }

        public int patientId { get; set; }
        TestController testController = new TestController();

        private void LabPatientProfile_Load(object sender, EventArgs e)
        {

        }


    }
}
