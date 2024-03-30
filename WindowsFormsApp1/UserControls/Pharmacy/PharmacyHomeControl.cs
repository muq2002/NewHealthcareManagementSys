using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareManagement.Screens.Controller;
using HealthcareManagement.Screens.Config;
using HealthcareManagement.UserControls.Pharmacy;

namespace HealthcareManagement.Screens.UserControls.Pharmacy
{
    public partial class PharmacyHomeControl : UserControl
    {
        PatientController patientController = new PatientController();
        public PharmacyHomeControl()
        {
            InitializeComponent();
        }

        private void PharmacyHomeControl_Load(object sender, EventArgs e)
        {
            fillPatientData(patientController.readPatients());
            updateTheDate();
        }

        private void updateTheDate()
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dddd, MMMM d, yyyy");

            dateLabel1.Text = formattedDate;
            dateLabel2.Text = formattedDate;
            dateLabel3.Text = formattedDate;
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
                };
                dataPatients.Rows.Add(data);
            }
            calculateStatictis();
        }
        void calculateStatictis()
        {
            totalNumberPatientsLabel.Text = dataPatients.Rows.Count.ToString();
        }
        private void dataPatients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            PharmacySellingPointControl pharmacySellingPointControl =
                new PharmacySellingPointControl();
            pharmacySellingPointControl
                .patientId = int.Parse(dataPatients.SelectedRows[0].Cells[0].Value.ToString());
            pharmacySellingPointControl.ShowDialog();

        }
    }
}
