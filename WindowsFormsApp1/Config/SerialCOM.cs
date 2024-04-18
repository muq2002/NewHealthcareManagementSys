using HealthcareManagement.Controller;
using HealthcareManagement.Model;
using HealthcareManagement.Properties;
using HealthcareManagement.Screens.Controller;
using HealthcareManagement.Screens.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Windows.Forms;

namespace HealthcareManagement.Config
{
    class SerialCOM
    {
        PatientController patientController = new PatientController();
        SessionController sessionController = new SessionController();
        PrescriptionController  prescriptionController = new PrescriptionController();
        TestController testController = new TestController();
        public void writeIntoSerial(string text)
        {
            string portName = Settings.Default.PortName;
            int baudRate = int.Parse(Settings.Default.BaudRate);
            SerialPort serialPort = new SerialPort(portName, baudRate);

            try
            {
                // Open the serial port
                serialPort.Open();
                serialPort.Write(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                serialPort.Close();
            }
        }


        public JObject managerToSerialInput(string data)
        {
            JObject message = JSONParing.convertStringToJson(data);
            if (message["from"].ToString() == "reg")
            {
                return manageRegisterMessages(message);
            }
            if (message["from"].ToString() == "doc" && message["to"].ToString() == "pha")
            {
                return manageDocToPhamarcyMessages(message);
            }
            if (message["from"].ToString() == "doc" && message["to"].ToString() == "lab")
            {
                return manageDocToLabMessages(message);
            }
            if (message["from"].ToString() == "lab" && message["to"].ToString() == "doc")
            {
                return manageLabToDocMessages(message);
            }

            return new JObject();
        }

        JObject manageDocToLabMessages(JObject message)
        {
            if (sessionController
                .getSingleSessionName(int.Parse(message["sessionId"].ToString())) == "")
            {
                createSession(message);
            }
            registerTestsIntoDatabase(message);
            return message;
        }


        public void registerTestsIntoDatabase(JObject message)
        {
            List<MyTest>[] testData = readArrayTests(message);
            foreach (var testItem in testData)
            {
                foreach (var test in testItem)
                {
                    testController.createTest(new TestModel()
                    {
                        PatientID = int.Parse(message["patientId"].ToString()),
                        SessionID = int.Parse(message["sessionId"].ToString()),
                        TestID = test.TestId,
                        TestValue = test.Value,
                        Comment = test.Comment
                    });
                }
            }
        }
        JObject manageLabToDocMessages(JObject message)
        {
            registerTestsIntoDatabase(message);
            return message;
        }


        #region Pharmacy
        JObject manageDocToPhamarcyMessages(JObject message)
        {
            if (sessionController
                .getSingleSessionName(int.Parse(message["sessionId"].ToString())) == "")
            {
                createSession(message);
            }

            // make sure the id of session
            registerDrugIntoDatabase(message);
            return message;
        }
        public void registerDrugIntoDatabase(JObject message)
        {
            List<MyDrug>[] drugData = readArrayDrugs(message);
            foreach (var drugItem in drugData)
            {
                foreach (var drug in drugItem)
                {
                    prescriptionController.createPrescription(new PrescriptionModel
                    {
                        PatientID = int.Parse(message["patientId"].ToString()),
                        SessionID = int.Parse(message["sessionId"].ToString()),
                        DrugID = drug.DrugId,
                        Instruction = drug.Instruction
                    });
                }
            }
        }

        public List<MyDrug>[] readArrayDrugs(JObject data)
        {
            JArray dataArray = (JArray)data["data"];
            List<MyDrug>[] result = new List<MyDrug>[dataArray.Count];

            for (int i = 0; i < dataArray.Count; i++)
            {
                JObject item = (JObject)dataArray[i];
                int drugId = (int)item["drugId"];
                string instruction = (string)item["instruction"];

                result[i] = new List<MyDrug>();
                result[i].Add(new MyDrug { DrugId = drugId, Instruction = instruction });
            }

            return result;
        }
        #endregion



        void createSession(JObject message)
        {
            SessionModel sessionModel = new SessionModel();
            sessionModel.PatientID = int.Parse(message["patientId"].ToString());
            sessionModel.SessionName = message["sessionName"].ToString();

            sessionController.createSession(sessionModel);

        }
        JObject manageRegisterMessages(JObject message)
        {

            if (patientController
                .getSinglePatient(int.Parse(message["id"].ToString())).Rows.Count > 0)
            {
                createPatient(message);
            }
            return message;
        }

        private void createPatient(JObject patient)
        {
            PatientModel patientModel = new PatientModel();
            patientModel.PatientUUID = patient["uuid"].ToString();
            patientModel.PatientName = patient["name"].ToString();
            patientModel.PatientAge = int.Parse(patient["age"].ToString());
            patientModel.PatientGender = int.Parse(patient["gender"].ToString());
            patientModel.PatientPhoneNumber = patient["phoneNumber"].ToString();

            patientController.createPatient(patientModel);
        }

        public List<MyTest>[] readArrayTests(JObject data)
        {
            JArray dataArray = (JArray)data["data"];
            List<MyTest>[] result = new List<MyTest>[dataArray.Count];

            for (int i = 0; i < dataArray.Count; i++)
            {
                JObject item = (JObject)dataArray[i];
                int testId = (int)item["testId"];
                string vaule = (string)item["value"];
                string comment = (string)item["comment"];

                result[i] = new List<MyTest>();
                result[i].Add(new MyTest { TestId = testId, Value = vaule, Comment = comment });
            }

            return result;
        }

    }

    class MyDrug
    {
        public int DrugId { get; set; }
        public string Instruction { get; set; }
    }

    class MyTest
    {
        public int TestId { get; set; }
        public string Value { get; set; }
        public string Comment { get; set; }
    }
}
