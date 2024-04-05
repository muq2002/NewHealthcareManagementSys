using HealthcareManagement.Config;
using HealthcareManagement.Properties;
using HealthcareManagement.Screens.Config;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;


namespace HealthcareManagement.Screens.Phamracy
{
    public partial class PharmacyHomeScreen : Form
    {
        private BackgroundWorker _backgroundWorker;
        static SerialPort mySerial = new SerialPort();
        public string errorMessage = "";

        public PharmacyHomeScreen()
        {
            InitializeComponent();
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerSupportsCancellation = true;
            _backgroundWorker.DoWork += BackgroundWorker_DoWork;
        }
        
        private void PharmacyHomeScreen_Load(object sender, EventArgs e)
        {
            createSideMenu();
            readDataFromSerial();
        }

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
            };
            pharmacyHomeControl1.dataPatients.Rows.Add(row);
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
