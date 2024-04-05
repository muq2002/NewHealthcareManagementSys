using HealthcareManagement.Screens.Config;
using HealthcareManagement.Screens.UserControls.Pharmacy;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthcareManagement.Screens.Phamracy
{
    partial class PharmacyHomeScreen : Form
    {
        PharmacyDrugList pharmacyDrugList = new PharmacyDrugList();
        PharmacyPatientsList pharmacyPatientsList = new PharmacyPatientsList();
        PharmacySettingsControl pharmacySettingsControl = new PharmacySettingsControl();

        private void createSideMenu()
        {
            pharmacyDrugList.Dock = DockStyle.Fill;
            container.Controls.Add(pharmacyDrugList);

            pharmacyPatientsList.Dock = DockStyle.Fill;
            container.Controls.Add(pharmacyPatientsList);

            pharmacySettingsControl.Dock = DockStyle.Fill;
            container.Controls.Add(pharmacySettingsControl);
        }

        #region Controls
        private void ordersBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            pharmacyHomeControl1.Visible = true;

            ordersBTN.IdleFillColor = Color.White;
            ordersBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);
        }
        private void PatientsBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            pharmacyPatientsList.Visible = true;

            PatientsBTN.IdleFillColor = Color.White;
            PatientsBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);
        }
        private void DrugsBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            pharmacyDrugList.Visible = true;

            DrugsBTN.IdleFillColor = Color.White;
            DrugsBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);
        }
        private void settingsBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            pharmacySettingsControl.Visible = true;

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
            pharmacyHomeControl1.Visible = false;
            pharmacyDrugList.Visible = false;
            pharmacyPatientsList.Visible = false;
            pharmacySettingsControl.Visible = false;
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
