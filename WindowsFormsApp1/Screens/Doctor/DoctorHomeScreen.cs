using System;
using System.Windows.Forms;
using HealthcareManagement.UserControls.Doctor;
using System.ComponentModel;
using System.IO.Ports;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Text;
using HealthcareManagement.Config;
using HealthcareManagement.Screens.Config;

namespace HealthcareManagement.Screens.Doctor
{
    public partial class DoctorHomeScreen : Form
    {

        private BackgroundWorker _backgroundWorker;
        static SerialPort mySerial = new SerialPort();
        public string errorMessage = "";
        public DoctorHomeScreen()
        {
            InitializeComponent();
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerSupportsCancellation = true;
            _backgroundWorker.DoWork += BackgroundWorker_DoWork;
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            readDataFromSerial();
            patientsListControl.Dock = DockStyle.Fill;
            container.Controls.Add(patientsListControl);

            doctorSettingsControl.Dock = DockStyle.Fill;
            container.Controls.Add(doctorSettingsControl);
        }

        void statusOfConnectivity(string connect) { }
        void fillPatientDataTable(string data)
        {
            JObject patient = JSONParing.convertStringToJson(data);
            object[] row =
            {
                patient["id"].ToString(),
                patient["uuid"].ToString(), 
                patient["name"].ToString(),
                patient["age"].ToString(),
                Utils.getGenderStr(patient["gender"].ToString()),
                patient["phoneNumber"].ToString()
            };
            doctorHomeControl1.dataPatients.Rows.Add(row);
        }
        private void DoctorHomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_backgroundWorker.IsBusy)
                _backgroundWorker.CancelAsync();
            mySerial.Close();
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
                mySerial.PortName = "COM4";
                mySerial.BaudRate = 9600;
                mySerial.Encoding = Encoding.UTF8;
                mySerial.Open();
            }
            catch(Exception ex)
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
                    e.Cancel = true;
                    return;
                }

                Thread.Sleep(5000);
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
