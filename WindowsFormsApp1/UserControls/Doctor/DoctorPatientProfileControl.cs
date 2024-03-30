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

namespace HealthcareManagement.UserControls.Doctor
{
    public partial class PatientProfileControl : UserControl
    {
        public PatientProfileControl()
        {
            InitializeComponent();
        }
        public int patientId { get; set; }
        public int sessionId { get; set; }

        TestController testController = new TestController();
        DrugsController drugsController = new DrugsController();

        PrescriptionController prescriptionController = new PrescriptionController();
        DiagnosisController diagnosisController = new DiagnosisController();


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
            DoctorSelectMedicalTests doctorSelectMedicalTests = new DoctorSelectMedicalTests();
            doctorSelectMedicalTests.patientID = patientId;
            doctorSelectMedicalTests.sessionID = sessionId;

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
            DiagnosisModel diagnosisModel = new DiagnosisModel();

            diagnosisModel.PatientID = patientId;
            diagnosisModel.SessionID = sessionId;
            diagnosisModel.Comments = richTextComments.Text;
            diagnosisModel.AutoDiagnosis = textAutomatedDiagnosis.Text;

            diagnosisController.saveDiagnosis(diagnosisModel);
        }

        private void printPrescriptionBTN_Click(object sender, EventArgs e)
        {
            MyPrinter myPrinter = new MyPrinter();
            HTMLDocument.createHtmltoPdf(myPrinter
                .createHTMLFileForPrescription(new PatientModel(), new DiagnosisModel(
                1,
                1,
                3,
                richTextComments.Text,
                textAutomatedDiagnosis.Text
                )));

            myPrinter.openPDFfile();
        }
    }
}
