using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareManagement.Config;
using HealthcareManagement.Screens.Config;
using HealthcareManagement.Screens.Controller;
using HealthcareManagement.Screens.Model;
using HealthcareManagement.Screens.UserControls.Registration;
using Newtonsoft.Json.Linq;
using ZXing;

namespace HealthcareManagement.UserControls.Doctor
{
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
        {
            InitializeComponent();
        }

        PatientController patientController = new PatientController();
        SerialCOM serialCOM = new SerialCOM();
        public int patientId = 0;
        #region Controls
        private void addPatientBTN_Click(object sender, EventArgs e)
        {
            try
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
            catch(Exception ex)
            {
                MessageBox.Show("There mistake, please solve it and try again.");
            }

        }

        void writeInSerial(PatientModel patientModel)
        {
            JObject jObj = new JObject();
            jObj["id"] = patientModel.PatientID;
            jObj["uuid"] = patientModel.PatientUUID;
            jObj["name"] = patientModel.PatientName;
            jObj["phoneNumber"] = patientModel.PatientPhoneNumber;
            jObj["age"] = patientModel.PatientAge;
            jObj["gender"] = patientModel.PatientGender;

            serialCOM.writeIntoSerial(jObj.ToString());
        }

        private void updataPatient()
        {
            PatientModel patientModel = new PatientModel();

            patientModel.PatientID = patientId;
            patientModel.PatientUUID = textUuid.Text;
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

            patientModel.PatientUUID = textUuid.Text;
            patientModel.PatientName = textName.Text;
            patientModel.PatientPhoneNumber = textPhoneNumber.Text;
            patientModel.PatientAge = int.Parse(textAge.Text);
            patientModel.PatientGender = getGender();

            patientController.createPatient(patientModel);
            writeInSerial(patientModel);

            MessageBox.Show("Patient Has been added successfully!");
            this.Close();
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
                return;
            }

            textUuid.Text = Utils.crateUUID();
            createQRCode(textUuid.Text);
        }

        void createQRCode(string text) {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = new ZXing.Common.EncodingOptions
            {
                Width = pictureBoxQRCode.Width, 
                Height = pictureBoxQRCode.Height,
                Margin = 0
            };
            Bitmap qrCodeImage = writer.Write(text);

            pictureBoxQRCode.Image = qrCodeImage;
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
