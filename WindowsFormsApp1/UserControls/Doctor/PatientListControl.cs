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
using HealthcareManagement.Controller;
using HealthcareManagement.UserControls.Doctor;

namespace HealthcareManagement.UserControls.Doctor
{
    public partial class PatientListControl : UserControl
    {
        public PatientListControl()
        {
            InitializeComponent();
        }
        PatientController patientController = new PatientController();
        SessionController sessionController = new SessionController();


        TestController testController = new TestController();
        PrescriptionController prescriptionController = new PrescriptionController();
        DiagnosisController diagnosisController = new DiagnosisController();

        public int patientID { get; set; }
        
        private void PatientListControl_Load(object sender, EventArgs e)
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

            patientProfileControl1.patientId = int.Parse(dataPatients
                .CurrentRow.Cells[0].Value.ToString());

            loadPatientSessions();
        }

        private void loadPatientSessions()
        {
            comboSessions.Text = "";
            comboSessions.DataSource = sessionController.getSingleSession(
                int.Parse(dataPatients.CurrentRow.Cells[0].Value.ToString()));
            comboSessions.DisplayMember = "SessionName";
            comboSessions.ValueMember = "ID";
        }

        private void loadPatientProfileControl()
        {
            dataPatients.Visible = false;

            patientProfileControl1.Visible = true;
            patientProfileControl1.BringToFront();
            patientProfileControl1.Dock = DockStyle.Fill;
            searchPatientText.Visible = false;
            comboSessions.Visible = true;
            picData.Visible = true;
            pictCreatenNewSesssion.Visible = true;
        }

        private void picData_Click(object sender, EventArgs e)
        {
            dataPatients.Visible = true;
            dataPatients.BringToFront();

            titleOfPageText.Text = "Patients List";
            searchPatientText.Visible = true;
            patientProfileControl1.Visible = false;
            comboSessions.Visible = false;
            picData.Visible = false;
            pictCreatenNewSesssion.Visible = false;

            patientProfileControl1.BringToFront();
        }

        private void searchPatientText_OnTextChange(object sender, EventArgs e)
        {
            if (searchPatientText.text == "") fillPatientData(patientController.readPatients());
            fillPatientData(patientController.searchPatients(searchPatientText.text));
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillPatientData(patientController.readPatients());
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isUserSelectedRow()) return;
            AddPatientForm addPatientForm = new AddPatientForm();

            patientID = int.Parse(dataPatients.SelectedRows[0].Cells["_id"].Value.ToString());
            addPatientForm.patientId = patientID;
            addPatientForm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isUserSelectedRow()) return;
            patientController.deletePatient(int.Parse(dataPatients.SelectedRows[0].Cells["_id"].Value.ToString()));
            fillPatientData(patientController.readPatients());
        }

        private bool isUserSelectedRow()
        {
            return dataPatients.SelectedRows.Count > 0;
        }

        private void comboSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSessions.SelectedValue.GetType().ToString() != "System.Int32") return;
            if (String.IsNullOrEmpty(comboSessions.SelectedValue.ToString())) return;

            int sessionId = int.Parse(
            comboSessions.SelectedValue.ToString());

            fillSessionData(testController.readTestsBySesssionID(sessionId));
            fillPrescriptionData(prescriptionController.getPrescriptionBySessionId(sessionId));
            fillDiagnosisData(diagnosisController.getDiagnosisBySessionId(sessionId));

            patientProfileControl1.sessionId = sessionId;

        }

        void fillSessionData(DataTable sessionData)
        {
            patientProfileControl1.dataTests.Rows.Clear();
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
                patientProfileControl1.dataTests.Rows.Add(data);
            }
        }

        void fillPrescriptionData(DataTable prescriptionData)
        {
            patientProfileControl1.dataPrescriptions.Rows.Clear();
            for (int index = 0; index < prescriptionData.Rows.Count; index++)
            {
                string[] data = new string[] {
                    prescriptionData.Rows[index][0].ToString(),
                    prescriptionData.Rows[index][3].ToString(),
                    prescriptionData.Rows[index][4].ToString(),
                };
                
                patientProfileControl1.dataPrescriptions.Rows.Add(data);
                patientProfileControl1.dataPrescriptions
                    .Rows[index].Cells[1].Value = int.Parse(prescriptionData.Rows[index][3].ToString());
            }
        }

        void fillDiagnosisData(DataTable diagnosisData)
        {
            // Reset values
            patientProfileControl1.textAutomatedDiagnosis.Text = "";
            patientProfileControl1.richTextComments.Text = "";

            if (diagnosisData.Rows.Count == 0) return;
            patientProfileControl1.
                textAutomatedDiagnosis.Text = diagnosisData.Rows[0][4].ToString();
            patientProfileControl1.
                richTextComments.Text = diagnosisData.Rows[0][3].ToString();
        }


        private void pictCreatenNewSesssion_Click(object sender, EventArgs e)
        {
            DoctorInputNewSession doctorInputNewSession = new DoctorInputNewSession();

            doctorInputNewSession.patientID = int.Parse(dataPatients
                .SelectedRows[0].Cells["_id"].Value.ToString());
            doctorInputNewSession.ShowDialog();

            loadPatientSessions();
        }
    }
}
