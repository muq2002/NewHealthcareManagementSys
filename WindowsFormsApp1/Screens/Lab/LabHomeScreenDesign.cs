using HealthcareManagement.Screens.Config;
using HealthcareManagement.Screens.UserControls;
using HealthcareManagement.UserControls.Lab;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthcareManagement.Screens.Lab
{
    partial class LabHomeScreen: Form
    {

                
        TestsListControl testsListControl = new TestsListControl();
        LabPatientsListControl patientsListControl = new LabPatientsListControl();
        LabSettingsControl labSettingsControl = new LabSettingsControl();

        private void createMenuSide()
        {
            testsListControl.Dock = DockStyle.Fill;
            container.Controls.Add(testsListControl);

            patientsListControl.Dock = DockStyle.Fill;
            container.Controls.Add(patientsListControl);

            labSettingsControl.Dock = DockStyle.Fill;
            container.Controls.Add(labSettingsControl);
        }

        #region Controls
        private void testsListBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            testsListControl.Visible = true;

            testsListBTN.IdleFillColor = Color.White;
            testsListBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);

        }

        private void ordersBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            labHomeControl1.Visible = true;

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

        private void settingsBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            labSettingsControl.Visible = true;

            settingsBTN.IdleFillColor = Color.White;
            settingsBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        void hiddenForms()
        {
            labHomeControl1.Visible = false;
            testsListControl.Visible = false;
            patientsListControl.Visible = false;
            labSettingsControl.Visible = false;
        }
        void convertColor()
        {

            for (int index = 0; index < 8; index++)
            {
                Utils.changeColor(index, sidebar);
            }

        }
    }
}
