using Bunifu.Framework.UI;
using HealthcareManagement.UserControls.Doctor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthcareManagement.Screens.Doctor
{
    public partial class DoctorHomeScreen : Form
    {
        PatientListControl patientsListControl = new PatientListControl();
        PatientProfileControl patientProfileControl = new PatientProfileControl();
        DoctorSettingsControl doctorSettingsControl = new DoctorSettingsControl();

        #region Buttons
        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ordersBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            doctorHomeControl1.Visible = true;

            ordersBTN.IdleFillColor = Color.White;
            ordersBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);

        }
        private void patientBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            patientsListControl.Visible = true;

            patientBTN.IdleFillColor = Color.White;
            patientBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);
        }
        private void StatisticsBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            patientProfileControl.Visible = true;

            StatisticsBTN.IdleFillColor = Color.White;
            StatisticsBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);
        }
        #endregion




        void hiddenForms()
        {
            doctorHomeControl1.Visible = false;
            patientsListControl.Visible = false;
            patientProfileControl.Visible = false;
            doctorSettingsControl.Visible = false;
        }
        void convertColor()
        {

            for (int index = 0; index < 6; index++)
            {
                changeColor(index);
            }

        }
        private void changeColor(int index)
        {
            foreach (var item in sidebar.Controls[index].Controls)
            {

                if (item is BunifuThinButton2 button)
                {
                    button.IdleFillColor = Color.FromArgb(56, 182, 255);
                    button.IdleForecolor = Color.White;
                }
            }
        }

        private void settingsBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            doctorSettingsControl.Visible = true;

            settingsBTN.IdleFillColor = Color.White;
            settingsBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);
        }
    }
}
