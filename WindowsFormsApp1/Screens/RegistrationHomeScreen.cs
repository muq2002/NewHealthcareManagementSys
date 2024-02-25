using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Config;
using WindowsFormsApp1.UserControls.Registration;

namespace WindowsFormsApp1.Screens
{
    public partial class RegistrationHomeScreen : Form
    {
        public RegistrationHomeScreen()
        {
            InitializeComponent();
        }
        RegistrationPatientListControl registrationPatientListControl
            = new RegistrationPatientListControl();
        RegistrationSettingsControl registrationSettingsControl 
            = new RegistrationSettingsControl();

        private void RegistrationHomeScreen_Load(object sender, EventArgs e)
        {
            registrationPatientListControl.Dock = DockStyle.Fill;
            container.Controls.Add(registrationPatientListControl);

            registrationSettingsControl.Dock = DockStyle.Fill;
            container.Controls.Add(registrationSettingsControl);
        }
        private void patientBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            registrationPatientListControl.Visible = true;

            patientBTN.IdleFillColor = Color.White;
            patientBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void hiddenForms()
        {
            registrationHomeControl2.Visible = false;
            registrationPatientListControl.Visible = false;
            registrationSettingsControl.Visible = false;
        }
        void convertColor()
        {

            for (int index = 0; index < 6; index++)
            {
                Utils.changeColor(index, sidebar);
            }

        }

        private void RegistrationBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            registrationHomeControl2.Visible = true;

            patientBTN.IdleFillColor = Color.White;
            patientBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);
        }

        private void SettingsBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            registrationSettingsControl.Visible = true;

            patientBTN.IdleFillColor = Color.White;
            patientBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);
        }
    }

}
