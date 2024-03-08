using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareManagementSystem.Config;
using HealthcareManagementSystem.Controller;
using HealthcareManagement.Controller;

namespace HealthcareManagementSystem.UserControls.Pharmacy
{
    public partial class PharmacyPatientsList : UserControl
    {
        PatientController patientController = new PatientController();
        PrescriptionController prescriptionController = new PrescriptionController();
        public PharmacyPatientsList()
        {
            InitializeComponent();
        }
        public int patientId { get; set; }
        private void PharmacyPatientsList_Load(object sender, EventArgs e)
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

        private void dataPatients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            loadPatientProfileControl();
            titleOfPageText.Text = dataPatients.CurrentRow.Cells[2].Value.ToString();
            patientId = int.Parse(dataPatients
                .CurrentRow.Cells[0].Value.ToString());
            pharmacyPatientProfileControl1.patientId = patientId;

            fillPrescriptionData(prescriptionController.getPrescriptionByPatientId(patientId));
        }

        private void picData_Click(object sender, EventArgs e)
        {
            dataPatients.Visible = true;
            dataPatients.BringToFront();

            titleOfPageText.Text = "Patients List";
            searchPatientText.Visible = true;
            pharmacyPatientProfileControl1.Visible = false;

            picData.Visible = false;

            pharmacyPatientProfileControl1.BringToFront();
        }


        private void loadPatientProfileControl()
        {
            dataPatients.Visible = false;

            pharmacyPatientProfileControl1.Visible = true;
            pharmacyPatientProfileControl1.BringToFront();
            pharmacyPatientProfileControl1.Dock = DockStyle.Fill;
            searchPatientText.Visible = false;

            picData.Visible = true;
        }

        void fillPrescriptionData(DataTable patientData)
        {
            pharmacyPatientProfileControl1.dataPrescription.Rows.Clear();
            for (int index = 0; index < patientData.Rows.Count; index++)
            {
                string[] data = new string[] {
                    patientData.Rows[index][0].ToString(),
                    patientData.Rows[index][3].ToString(),
                    patientData.Rows[index][4].ToString(),
                    patientData.Rows[index][5].ToString(),
                    patientData.Rows[index][6].ToString(),

                };
                pharmacyPatientProfileControl1.dataPrescription.Rows.Add(data);
            }
        }

        private void searchPatientText_OnTextChange(object sender, EventArgs e)
        {
            if (searchPatientText.text == "") fillPatientData(patientController.readPatients());
            fillPatientData(patientController.searchPatients(searchPatientText.text));
        }
    }
}
