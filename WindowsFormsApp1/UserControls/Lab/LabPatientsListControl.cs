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

namespace HealthcareManagementSystem.UserControls
{
    public partial class LabPatientsListControl : UserControl
    {
        public LabPatientsListControl()
        {
            InitializeComponent();
        }
        PatientController patientController = new PatientController();

        private void LabPatientsListControl_Load(object sender, EventArgs e)
        {

            fillPatientData(patientController.readPatients());
        }

        void fillPatientData(DataTable patientData)
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
    }
}
