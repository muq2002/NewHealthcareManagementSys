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
using HealthcareManagementSystem.Config;

namespace HealthcareManagementSystem.UserControls.Registration
{
    public partial class RegistrationSettingsControl : UserControl
    {
        public RegistrationSettingsControl()
        {
            InitializeComponent();
        }
        PatientController patientController = new PatientController();
        private void RegistrationSettingsControl_Load(object sender, EventArgs e)
        {
            patientController.DeleteStatus = "Yes";
            loadDeletedPtients(patientController.readPatients());
        }

        private void loadDeletedPtients(DataTable patientData)
            {
                dataPatients.Rows.Clear();
                for (int index = 0; index < patientData.Rows.Count; index++)
                {
                    string[] data = new string[] {
                    patientData.Rows[index][0].ToString(),
                    patientData.Rows[index][1].ToString(),
                    patientData.Rows[index][2].ToString(),
                    patientData.Rows[index][3].ToString(),
                    Utils.getGenderStr(patientData.Rows[index][4].ToString()),
                    patientData.Rows[index][5].ToString(),
                    patientData.Rows[index][6].ToString(),
                };
                    dataPatients.Rows.Add(data);
                }
            
        }


        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patientController.DeleteStatus = "Yes";
            loadDeletedPtients(patientController.readPatients());
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isUserSelectedRow()) return;
            patientController.restorePatient(int.Parse(dataPatients
                .SelectedRows[0].Cells["_id"].Value.ToString()));

            patientController.DeleteStatus = "Yes";
            loadDeletedPtients(patientController.readPatients());
        }

        private bool isUserSelectedRow()
        {
            return dataPatients.SelectedRows.Count > 0;
        }
    }
}
