using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareManagement.Screens.Config;
using HealthcareManagement.Screens.Screens;
using HealthcareManagement.Screens.UserControls;
using HealthcareManagement.UserControls.Lab;
using System.IO.Ports;
using Newtonsoft.Json.Linq;
using HealthcareManagement.Config;
using HealthcareManagement.Properties;
using HealthcareManagement.Screens.Controller;

namespace HealthcareManagement.Screens.Lab
{
    public partial class LabHomeScreen : Form
    {
        private BackgroundWorker _backgroundWorker;
        static SerialPort mySerial = new SerialPort();
        public string errorMessage = "";

        SerialCOM serialCOM = new SerialCOM();
        PatientController patientController = new PatientController();
        public LabHomeScreen()
        {
            InitializeComponent();
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerSupportsCancellation = true;
            _backgroundWorker.DoWork += BackgroundWorker_DoWork;
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            createMenuSide();
            readDataFromSerial();
        }

        void fillPatientDataTable(string data)
        {
            JObject patient = serialCOM.managerToSerialInput(data);

            DataTable queryPatient = patientController
                .getSinglePatient(int.Parse(patient["patientId"].ToString()));
            object[] row =
            {
               queryPatient.Rows[0][0],
               queryPatient.Rows[0][1],
               queryPatient.Rows[0][2],
               queryPatient.Rows[0][3],
               Utils.getGenderStr(queryPatient.Rows[0][4].ToString()),
            };
            labHomeControl1.dataPatients.Rows.Add(row);
        }

        #region Connectivity 
        private void readDataFromSerial()
        {
            try
            {
                _backgroundWorker.RunWorkerAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void setingPort()
        {
            try
            {
                mySerial.PortName = Settings.Default.PortName;
                mySerial.BaudRate = int.Parse(Settings.Default.BaudRate);
                mySerial.Encoding = Encoding.UTF8;
                mySerial.Open();
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

        }
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            setingPort();
            while (!worker.CancellationPending)
            {
                try
                {
                    string data = mySerial.ReadLine();
                    UpdateUIWithSerialData(data);
                }
                catch (Exception ex)
                {
                    errorMessage = ex.Message;

                    return;
                }

                //Thread.Sleep(1000);
            }
        }
        private void UpdateUIWithSerialData(string data)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() => UpdateUIWithSerialData(data)));
                return;
            }
            fillPatientDataTable(data);
        }
        #endregion
    }
}
