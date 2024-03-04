using HealthcareManagement.Controller;
using HealthcareManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthcareManagement.UserControls.Doctor
{
    public partial class DoctorInputNewSession : Form
    {
        public DoctorInputNewSession()
        {
            InitializeComponent();
        }
        SessionController sessionController = new SessionController();
        public int patientID = 0;
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createSessionBTN_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textSession.Text)) return;
            sessionController.createSession(createSessionModel());
            this.Close();
        }

        private SessionModel createSessionModel()
        {
            return new SessionModel
            {
                SessionName = textSession.Text,
                PatientID = patientID
            };
        }
    }
}
