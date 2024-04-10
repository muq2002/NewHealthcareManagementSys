using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareManagement.UserControls.Doctor;
using HealthcareManagement.Screens.Controller;
using HealthcareManagement.Model;
using HealthcareManagement.Controller;
using HealthcareManagement.Config;
using HealthcareManagement.Screens.Model;
using HealthcareManagement.External;

namespace HealthcareManagement.UserControls.Doctor
{
    public partial class PatientProfileControl : UserControl
    {
        public PatientProfileControl()
        {
            InitializeComponent();
        }
        public int patientId { get; set; }
        public int patientAge { get; set; }
        public int sessionId { get; set; }

        bool saveDrugIntoDatabase = false;

        TestController testController = new TestController();
        DrugsController drugsController = new DrugsController();
        SessionController sessionController = new SessionController();

        PrescriptionController prescriptionController = new PrescriptionController();
        DiagnosisController diagnosisController = new DiagnosisController();
        SerialCOM serialCOM = new SerialCOM();

        DLModel DLModelConfig = new DLModel();

        private void PatientProfileControl_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            createPrescriptionTable();
        }

        void createPrescriptionTable()
        {
            dataPrescriptions.Columns.Clear();

            DataGridViewTextBoxColumn _textColumn1 = new DataGridViewTextBoxColumn();
            _textColumn1.HeaderText = "ID";
            _textColumn1.Width = 60;
            _textColumn1.Visible = false;
            dataPrescriptions.Columns.Add(_textColumn1);

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Drugs Name";
            comboBoxColumn.Width = 300;

            comboBoxColumn.DisplayMember = "DrugName";
            comboBoxColumn.ValueMember = "ID";
            comboBoxColumn.DataSource = drugsController.readDrugsNames();

            dataPrescriptions.Columns.Add(comboBoxColumn);

            DataGridViewTextBoxColumn _textColumn2 = new DataGridViewTextBoxColumn();
            _textColumn2.HeaderText = "Instrcutions";
            _textColumn2.Width = 300;
            dataPrescriptions.Columns.Add(_textColumn2);

        }

        private void openMedicalTests_Click(object sender, EventArgs e)
        {
            if(sessionId == 0)
            {
                MessageBox.Show("Please select the session.");
                return;
            }
            DoctorSelectMedicalTests doctorSelectMedicalTests = new DoctorSelectMedicalTests();
            doctorSelectMedicalTests.patientId = patientId;
            doctorSelectMedicalTests.sessionId = sessionId;

            doctorSelectMedicalTests.ShowDialog();
            fillSessionData(testController.readTestsBySesssionID(sessionId));
        }

        void fillSessionData(DataTable sessionData)
        {
            dataTests.Rows.Clear();
            for (int index = 0; index < sessionData.Rows.Count; index++)
            {
                string[] data = new string[] {
                    sessionData.Rows[index][0].ToString(),
                    sessionData.Rows[index][3].ToString(),
                    sessionData.Rows[index][4].ToString(),
                    "",
                    sessionData.Rows[index][5].ToString(),
                    sessionData.Rows[index][6].ToString(),
                    "Pending"
                };
                dataTests.Rows.Add(data);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveTheDrugIntoDatabase();
            saveDrugIntoDatabase = true;
        }

        private void saveTheDrugIntoDatabase()
        {

            for (int index = 0; index < dataPrescriptions.Rows.Count - 1; index++)
            {
                if (dataPrescriptions
                    .Rows[index].Cells[0].Value != null) continue;
                prescriptionController.createPrescription(createPrescriptionModel(index));
            }
        }

        PrescriptionModel createPrescriptionModel(int index)
        {
            return new PrescriptionModel
            {
                PatientID = patientId,
                SessionID = sessionId,
                DrugID = int.Parse(dataPrescriptions
                .Rows[index].Cells[1].Value.ToString()),
                Instruction = dataPrescriptions.Rows[index].Cells[2].Value == null ?
                "" : dataPrescriptions.Rows[index].Cells[2].Value.ToString()
            };
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void savePatientBTN_Click(object sender, EventArgs e)
        {
            //DiagnosisModel diagnosisModel = new DiagnosisModel();

            //diagnosisModel.PatientID = patientId;
            //diagnosisModel.SessionID = sessionId;
            //diagnosisModel.Comments = richTextComments.Text;
            //diagnosisModel.AutoDiagnosis = textAutomatedDiagnosis.Text;

            //diagnosisController.saveDiagnosis(diagnosisModel);

            // Send Through Serial
            string message = @"{""from"": ""doc"", ""to"": ""pha"", ""patientId"": "+ patientId.ToString()
                + @", ""sessionId"": " + sessionId.ToString() + @", ""sessionName"": """ +
                sessionController.getSingleSessionName(sessionId) + @""",""data"":[" + drugsToJsonText() + "]}";
            MessageBox.Show(message);
            serialCOM.registerDrugIntoDatabase(JSONParing.convertStringToJson(message));
            //serialCOM.writeIntoSerial(message);
        }
        string drugsToJsonText() {
            string buffer = "";
            for(int index = 0; index < dataPrescriptions.Rows.Count - 1; index++)
            {
                string temp = @"{ ""drugId"": " + dataPrescriptions.Rows[index]
                .Cells[1].Value.ToString()
                + @", ""instruction"": """ + dataPrescriptions.Rows[index]
                .Cells[2].Value.ToString() + @"""},";
                if (index == dataPrescriptions.Rows.Count - 2)
                {
                     temp = @"{ ""drugId"": " + dataPrescriptions.Rows[index]
                        .Cells[1].Value.ToString()
                        + @", ""instruction"": """ + dataPrescriptions.Rows[index]
                        .Cells[2].Value.ToString() + @"""}";
                }

                buffer += temp;
            }
            return buffer;
        }
        private void printPrescriptionBTN_Click(object sender, EventArgs e)
        {
            MyPrinter myPrinter = new MyPrinter();
            HTMLDocument.createHtmltoPdf(myPrinter
                .createHTMLFileForPrescription(patientId, new DiagnosisModel(
                1,
                1,
                3,
                richTextComments.Text,
                textAutomatedDiagnosis.Text
                ), fillPrescription() ));

            myPrinter.openPDFfile();
        }

        DataTable fillPrescription()
        {
            DataTable result = new DataTable();

            foreach (DataGridViewColumn column in dataPrescriptions.Columns)
            {
                result.Columns.Add(column.Name, typeof(string));
            }

            foreach (DataGridViewRow row in dataPrescriptions.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
                    DataRow newRow = result.NewRow();

                    newRow[0] = drugsController.getDrugName(int.Parse(row
                        .Cells[1].Value.ToString())).Rows[0][0].ToString();
                    newRow[1] = row.Cells[2].Value.ToString();

                    result.Rows.Add(newRow);
                }
            }
            return result;
        }

        private void runCADBTN_Click(object sender, EventArgs e)
        {
            TestsBankController testsBankController = new TestsBankController();
            string inputValue = convertString(testsBankController
                .getMachinelearningParameters(9, patientId));

            string prompt = patientAge.ToString() + inputValue + " 0";
            //MessageBox.Show(prompt);
            textAutomatedDiagnosis.Text =  DLModelConfig
                .sendPredictionForKidneyModel(prompt);
        }

        string convertString(DataTable machineValues) {
            string buffer = "";

            for (int index = 0; index < machineValues.Rows.Count -1; index ++)
            {
                buffer += " " + machineValues.Rows[index][5].ToString();
            }

            return buffer;
        }

        private void dataPrescriptions_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            saveDrugIntoDatabase = false;
        }
    }
}
