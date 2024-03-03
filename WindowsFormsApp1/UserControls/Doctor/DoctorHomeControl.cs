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

namespace HealthcareManagementSystem.UserControls.Doctor
{
    public partial class DoctorHomeControl : UserControl
    {
        public DoctorHomeControl()
        {
            InitializeComponent();
        }
        PatientController patientController = new PatientController();
        private void addPatientBTN_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.ShowDialog();
        }

        private void DoctorHomeControl_Load(object sender, EventArgs e)
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
                    patientData.Rows[index][5].ToString(),

                };
                dataPatients.Rows.Add(data);
            }
            calculateStatictis();
        }

        private void dataPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void calculateStatictis()
        {
            totalNumberPatientsLabel.Text = (dataPatients.Rows.Count - 1).ToString();
        }
        private void searchPatientText_OnTextChange(object sender, EventArgs e)
        {
            if (searchPatientText.text == "") fillPatientData(patientController.readPatients());
            fillPatientData(patientController.searchPatients(searchPatientText.text));
        }
    }
}
