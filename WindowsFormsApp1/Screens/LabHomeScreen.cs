using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareManagementSystem.Config;
using HealthcareManagementSystem.Screens;
using HealthcareManagementSystem.UserControls;
using HealthcareManagement.UserControls.Lab;

namespace HealthcareManagementSystem
{
    public partial class LabHomeScreen : Form
    {
        public LabHomeScreen()
        {
            InitializeComponent();
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TestsListControl testsListControl = new TestsListControl();
        LabPatientsListControl patientsListControl = new LabPatientsListControl();
        LabSettingsControl labSettingsControl = new LabSettingsControl();
        private void HomeScreen_Load(object sender, EventArgs e)
        {
            testsListControl.Dock = DockStyle.Fill;
            container.Controls.Add(testsListControl);

            patientsListControl.Dock = DockStyle.Fill;
            container.Controls.Add(patientsListControl);

            labSettingsControl.Dock = DockStyle.Fill;
            container.Controls.Add(labSettingsControl);
        }

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
            homeControl1.Visible = true;

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


        void hiddenForms() {
            homeControl1.Visible = false;
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

        private void settingsBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            labSettingsControl.Visible = true;

            settingsBTN.IdleFillColor = Color.White;
            settingsBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);
        }
    }
}
