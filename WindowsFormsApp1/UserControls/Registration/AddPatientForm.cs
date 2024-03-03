using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareManagementSystem.Config;
using HealthcareManagementSystem.Controller;
using HealthcareManagementSystem.Model;
using HealthcareManagementSystem.UserControls.Registration;

namespace HealthcareManagementSystem.UserControls.Doctor
{
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
        {
            InitializeComponent();
        }

        PatientController patientController = new PatientController();
        public int patientId = 0;
        #region Controls
        private void addPatientBTN_Click(object sender, EventArgs e)
        {
            if (patientId == 0)
            {
                insertNewPatient();
            }
            else
            {
                updataPatient();
            }
        }

        private void updataPatient()
        {
            PatientModel patientModel = new PatientModel();

            patientModel.PatientID = patientId;
            patientModel.PatientUUID = int.Parse(textUuid.Text);
            patientModel.PatientName = textName.Text;
            patientModel.PatientPhoneNumber = textPhoneNumber.Text;
            patientModel.PatientAge = int.Parse(textAge.Text);
            patientModel.PatientGender = getGender();

            patientController.updatePatient(patientModel);
            MessageBox.Show("Patient Has been updated successfully!");
            Close();
        }

        private void insertNewPatient()
        {
            PatientModel patientModel = new PatientModel();

            patientModel.PatientUUID = int.Parse(textUuid.Text);
            patientModel.PatientName = textName.Text;
            patientModel.PatientPhoneNumber = textPhoneNumber.Text;
            patientModel.PatientAge = int.Parse(textAge.Text);
            patientModel.PatientGender = getGender();

            patientController.createPatient(patientModel);
            MessageBox.Show("Patient Has been added successfully!");
            Close();
        }

        int getGender() {
            string gender = comboGender.SelectedText.ToString();
            if (gender == "Female") return 0;
            return 1;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void AddPatientForm_Load(object sender, EventArgs e)
        {
            if (patientId != 0)
            {
                loadSelectedPatientData();
                addPatientBTN.Text = "Update";
            }
            
        }

        private void loadSelectedPatientData()
        {
            DataTable selectedPatient = patientController.getSinglePatient(patientId);

            textUuid.Text = selectedPatient.Rows[0][1].ToString();
            textName.Text = selectedPatient.Rows[0][2].ToString();
            textAge.Text = selectedPatient.Rows[0][3].ToString();
            comboGender.Text = Utils.getGenderStr(selectedPatient.Rows[0][4].ToString());
            textPhoneNumber.Text = selectedPatient.Rows[0][5].ToString();
            
        }
    }
}
