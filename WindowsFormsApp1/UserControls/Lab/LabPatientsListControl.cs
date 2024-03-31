using System;
using System.Data;
using System.Windows.Forms;
using HealthcareManagement.Screens.Controller;
using HealthcareManagement.Screens.Config;
using HealthcareManagement.Config;
using HealthcareManagement.Screens.Model;

namespace HealthcareManagement.Screens.UserControls
{
    public partial class LabPatientsListControl : UserControl
    {
        public LabPatientsListControl()
        {
            InitializeComponent();
        }
        PatientController patientController = new PatientController();
        TestController testController = new TestController();

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

        private void picData_Click(object sender, EventArgs e)
        {
            dataPatients.Visible = true;
            dataPatients.BringToFront();

            titleOfPageText.Text = "Patients List";
            searchPatientText.Visible = true;
            labPatientProfile1.Visible = false;
            picData.Visible = false;


            labPatientProfile1.BringToFront();
        }

        private void dataPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            loadPatientProfileControl();
            titleOfPageText.Text = dataPatients.CurrentRow.Cells[2].Value.ToString();
            int patientId = int.Parse(dataPatients
                .CurrentRow.Cells[0].Value.ToString());

            labPatientProfile1.patientId = patientId;
            fillPatientTestsData(testController.readTestsByPatientID(patientId));
        }

        void fillPatientTestsData(DataTable patientTestData)
        {
            labPatientProfile1.dataTests.Rows.Clear();
            for (int index = 0; index < patientTestData.Rows.Count; index++)
            {
                string[] data = new string[] {
                    patientTestData.Rows[index][0].ToString(),
                    patientTestData.Rows[index][3].ToString(),
                    patientTestData.Rows[index][4].ToString(),
                    "",
                    patientTestData.Rows[index][5].ToString(),
                    patientTestData.Rows[index][6].ToString(),
                };
                labPatientProfile1.dataTests.Rows.Add(data);
            }
        }

        private void loadPatientProfileControl()
        {
            dataPatients.Visible = false;

            labPatientProfile1.Visible = true;
            labPatientProfile1.BringToFront();
            labPatientProfile1.Dock = DockStyle.Fill;
            searchPatientText.Visible = false;

            picData.Visible = true;

        }

        private void searchPatientText_OnTextChange(object sender, EventArgs e)
        {
            if (searchPatientText.text == "") fillPatientData(patientController.readPatients());
            fillPatientData(patientController.searchPatients(searchPatientText.text));
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //if (!isUserSelectedRow()) return;


            MyPrinter myPrinter = new MyPrinter();

            HTMLDocument.createHtmltoPdf(myPrinter
                .createHTMLFileForLab(new PatientModel(), fillTests()));
            myPrinter.openPDFfile();
        }
        DataTable fillTests()
        {
            DataTable result = new DataTable();

            foreach (DataGridViewColumn column in labPatientProfile1.dataTests.Columns)
            {
                result.Columns.Add(column.Name, typeof(string));
            }

            foreach (DataGridViewRow row in labPatientProfile1.dataTests.Rows)
            {
                DataRow newRow = result.NewRow();

                newRow[0] = row.Cells[0].Value.ToString();
                newRow[1] = row.Cells[1].Value.ToString();
                newRow[2] = row.Cells[2].Value.ToString();
                newRow[3] = row.Cells[3].Value.ToString();

                result.Rows.Add(newRow);
            }
            return result;
        }

        private bool isUserSelectedRow()
        {
            return labPatientProfile1.dataTests.SelectedRows.Count > 0;
        }
    }
}
