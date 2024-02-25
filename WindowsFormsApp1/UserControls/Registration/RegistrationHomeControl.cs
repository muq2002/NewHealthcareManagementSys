using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.UserControls.Doctor;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.UserControls.Registration
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
                    getGenderStr(patientData.Rows[index][4].ToString()),
                    patientData.Rows[index][5].ToString(),
                    patientData.Rows[index][6].ToString(),
                };
                dataPatients.Rows.Add(data);
            }
        }

        string getGenderStr(string gender) {
            if (gender == "1") return "Male";
            return "Female";
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
    }
}
