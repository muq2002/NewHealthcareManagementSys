using System;
using System.Data;
using System.Windows.Forms;
using HealthcareManagement.UserControls.Doctor;
using HealthcareManagement.Screens.Controller;
using HealthcareManagement.Screens.Config;
using HealthcareManagement.Config;
using HealthcareManagement.Screens.Model;

namespace HealthcareManagement.Screens.UserControls.Registration
{
    public partial class RegistrationHomeControl : UserControl
    {
        public RegistrationHomeControl()
        {
            InitializeComponent();
        }
        PatientController patientController = new PatientController();
        private void addPatientBTN_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.ShowDialog();
            // Refresh to patient table.
            fillPatientData(patientController.readPatients());
        }

        private void RegistrationHomeControl_Load(object sender, EventArgs e)
        {
            fillPatientData(patientController.readPatients());
        }
        void fillPatientData(DataTable patientData) {
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


        private void textSearch_OnTextChange(object sender, EventArgs e)
        {
            if (textSearch.text == "") fillPatientData(patientController.readPatients());
            fillPatientData(patientController.searchPatients(textSearch.text));
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            fillPatientData(patientController.readPatients());
        }



        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isUserSelectedRow()) return;
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.patientId = int.Parse(dataPatients.SelectedRows[0].Cells["_id"].Value.ToString());
            addPatientForm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isUserSelectedRow()) return;
            patientController.deletePatient(int.Parse(dataPatients
                .SelectedRows[0].Cells["_id"].Value.ToString()));
            fillPatientData(patientController.readPatients());
        }

        private bool isUserSelectedRow()
        {
            return dataPatients.SelectedRows.Count > 0;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillPatientData(patientController.readPatients());
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isUserSelectedRow()) return;


            MyPrinter myPrinter = new MyPrinter();

            HTMLDocument.createHtmltoPdf(myPrinter
                .createHTMLFileForRegistration(getPatientModel()));
            myPrinter.openPDFfile();
        }

        private PatientModel getPatientModel()
        {
            PatientModel patientModel = new PatientModel();
            patientModel.PatientUUID = dataPatients.SelectedRows[0]
                .Cells[1].Value.ToString();
            patientModel.PatientName = dataPatients.SelectedRows[0]
                .Cells[2].Value.ToString();
            patientModel.PatientAge = int.Parse(dataPatients.SelectedRows[0]
                .Cells[3].Value.ToString());
            patientModel.PatientGender = Utils.getGenderNumber(dataPatients.SelectedRows[0]
                .Cells[4].Value.ToString());

            patientModel.PatientPhoneNumber = dataPatients.SelectedRows[0]
                .Cells[5].Value.ToString();
            patientModel.RegisterDate = dataPatients.SelectedRows[0]
                .Cells[6].Value.ToString();
            return patientModel;
        }
    }
}
