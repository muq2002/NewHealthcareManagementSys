using HealthcareManagement.Model;
using HealthcareManagement.Screens.Config;
using HealthcareManagement.Screens.Controller;
using HealthcareManagement.Screens.Model;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using ZXing;

namespace HealthcareManagement.Config
{
    class MyPrinter
    {
        public string getPatientDetails(int patientId) {

            PatientController patientController = new PatientController();
            DataTable myPatient = patientController.getSinglePatient(patientId);

            QRCodeConfig.createQRPatientImage(myPatient.Rows[0][1].ToString());

            return @"
            <div class='patient-info'>
                    <h2>Patient Details</h2>
                    <p><strong>Name:</strong>" + myPatient.Rows[0][2].ToString() + @"</p>
                    <p><strong>Age:</strong> " + myPatient.Rows[0][3].ToString() + @"</p>
                    <p><strong>Sex:</strong> " + Utils.getGenderStr(myPatient.Rows[0][4].ToString()) + @"</p>
                    <p><strong>Phone:</strong> " + myPatient.Rows[0][5].ToString() + @"</p>
             </div>
             <div class='qr-code'>
                 <img src='qr_code.png' alt='QR Code'>
             </div>
            ";
        }


        public string createHTMLFileForPharmacy(int patientId, DataTable drugs)
        {
            return @"
        <html>
        <head>
            <title>Patient Invoice</title>
            <style>
                /* Add your CSS styles here */
                body {
                    font-family: Arial, sans-serif;
                }
                header {
                    text-align: center;
                    margin-bottom: 20px;
                }
                footer {
                    text-align: center;
                    margin-top: 20px;
                }
                .patient-details:after {
                    content: '';
                    display: table;
                    clear: both;
                }
                .patient-info {
                    float: left;
                    width: 70%; /* Adjust width as needed */
                }
                .qr-code {
                    float: right;
                    width: 30%; /* Adjust width as needed */
                    text-align: right;
                }
                .qr-code img {
                    max-height: 120px;
                }
                table {
                    width: 100%;
                    border-collapse: collapse;
                }
                th, td {
                    border: 1px solid black;
                    padding: 8px;
                    text-align: left;
                }
            </style>
        </head>
        <body>
            <header>
                <h1>Drugs Invoice</h1>
            </header>
            <div class='patient-details'>
                " + getPatientDetails(patientId) + @"
            </div>
            <br />
            <div class='tests-details'>
                <h2>Invoice Details</h2>
                <table id='items'>
                    <thead>
                        <tr>
                            <th>*</th>
                            <th>Drug Name</th>
                            <th>Qty</th>
                            <th>Price</th>
                            <th>Instructions</th>
                        </tr>
                    </thead>
                    <tbody>" + createDrugTable(drugs) + @"
                    </tbody>
                </table>
            </div>
            <footer>
                <p>Thank you for your business!</p>
            </footer>
        </body>
        </html>";
        }

        private static string createDrugTable(DataTable drugs)
        {
            string drugsTable = "";
            foreach (DataRow test in drugs.Rows)
            {
                drugsTable += @"<tr>
                            <td></td>
                            <td>" + test[0] + @"</td>
                            <td>" + test[1] + @"</td>
                            <td>" + test[2] + @"</td>
                            <td>" + test[3] + @"</td>
                        </tr>";
            }

            return drugsTable;
        }

        public string createHTMLFileForLab(PatientModel patientModel, DataTable tests)
        {
            string testsTable = "";
            foreach(DataRow test in tests.Rows)
            {
                testsTable += testsTable + @"<tr>
                            <td>*</td>
                            <td>" + test[0] + @"</td>
                            <td>" + test[1] + @"</td>
                            <td>" + test[2] + @"</td>
                        </tr>";
            }
                return @"
        <html>
        <head>
            <title>Patient Tests Lab Report</title>
            <style>
                /* Add your CSS styles here */
                body {
                    font-family: Arial, sans-serif;
                }
                header {
                    text-align: center;
                    margin-bottom: 20px;
                }
                footer {
                    text-align: center;
                    margin-top: 20px;
                }
                .patient-details:after {
                    content: '';
                    display: table;
                    clear: both;
                }
                .patient-info {
                    float: left;
                    width: 70%; /* Adjust width as needed */
                }
                .qr-code {
                    float: right;
                    width: 30%; /* Adjust width as needed */
                    text-align: right;
                }
                .qr-code img {
                    max-height: 120px;
                }
                table {
                    width: 100%;
                    border-collapse: collapse;
                }
                th, td {
                    border: 1px solid black;
                    padding: 8px;
                    text-align: left;
                }
            </style>
        </head>
        <body>
            <header>
                <h1>Clinical Report</h1>
            </header>
            <div class='patient-details'>
                <div class='patient-info'>
                    <h2>Patient Details</h2>
                    <p><strong>Name:</strong>" + patientModel.PatientName + @"</p>
                    <p><strong>Age:</strong> " + patientModel.PatientAge + @"</p>
                    <p><strong>Sex:</strong> " + Utils.getGenderStr(patientModel
                    .PatientGender.ToString()) + @"</p>
                    <p><strong>Phone:</strong> " + patientModel.PatientPhoneNumber + @"</p>
                </div>
                <div class='qr-code'>
                    <img src='https://www.scandit.com/cdn-cgi/image/width=300,height=300,fit=crop,quality=80,gravity=auto,sharpen=1,metadata=none,format=auto,onerror=redirect/wp-content/uploads/2019/08/Symbology-QR-code.svg' alt='QR Code'>
                </div>
            </div>
            <br />
            <div class='tests-details'>
                <h2>Tests Details</h2>
                <table id='items'>
                    <thead>
                        <tr>
                            <th>*</th>
                            <th>Test Name</th>
                            <th>Value</th>
                            <th>Normal Range</th>
                        </tr>
                    </thead>
                    <tbody>" + testsTable + @"
                    </tbody>
                </table>
            </div>
            <footer>
                <p>Thank you for your business!</p>
            </footer>
        </body>
        </html>";
        
            
        }

        public string createHTMLFileForRegistration(PatientModel patientModel)
        {
            return @"
        <html>
        <head>
            <title>Patient Info</title>
            <style>
                /* Add your CSS styles here */
                body {
                    font-family: Arial, sans-serif;
                }
                header {
                    text-align: center;
                    margin-bottom: 20px;
                }
                footer {
                    text-align: center;
                    margin-top: 20px;
                }
                .patient-details:after {
                    content: '';
                    display: table;
                    clear: both;
                }
                .patient-info {
                    float: left;
                    width: 60%; /* Adjust width as needed */
                }
                .qr-code {
                    float: right;
                    width: 40%; /* Adjust width as needed */
                    text-align: right;
                }
                .qr-code img {
                    max-height: 120px;
                }
            </style>
        </head>
        <body>
            <header>
                <h1>Patient Info Report</h1>
            </header>
            <div class='patient-details'>
                <div class='patient-info'>
                    <h2>Patient Details</h2>
                    <p><strong>UUID:</strong> " + patientModel.PatientUUID + @"</p>
                    <p><strong>Name:</strong>" + patientModel.PatientName + @"</p>
                    <p><strong>Age:</strong> " + patientModel.PatientAge + @"</p>
                    <p><strong>Sex:</strong> " + Utils.getGenderStr(patientModel
                    .PatientGender.ToString()) + @"</p>
                    <p><strong>Phone:</strong> " + patientModel.PatientPhoneNumber + @"</p>
                    <p><strong>Register Date:</strong> " + patientModel.RegisterDate + @"</p>
                </div>
                <div class='qr-code'>
                    <img src='https://www.scandit.com/cdn-cgi/image/width=300,height=300,fit=crop,quality=80,gravity=auto,sharpen=1,metadata=none,format=auto,onerror=redirect/wp-content/uploads/2019/08/Symbology-QR-code.svg' alt='QR Code'>
                </div>
            </div>
            <br />
            <footer>
                <p>Thank you for your business!</p>
            </footer>
        </body>
        </html>";

        }
        public string createHTMLFileForPrescription(int patientId,
            DiagnosisModel diagnosisModel, DataTable prescriptionData)
        {
            return @"
        <html>
        <head>
            <title>Patient Tests Lab Report</title>
            <style>
                /* Add your CSS styles here */
                body {
                    font-family: Arial, sans-serif;
                }
                header {
                    text-align: center;
                    margin-bottom: 20px;
                }
                footer {
                    text-align: center;
                    margin-top: 20px;
                }
                .patient-details:after {
                    content: '';
                    display: table;
                    clear: both;
                }
                .patient-info {
                    float: left;
                    width: 70%; /* Adjust width as needed */
                }
                .qr-code {
                    float: right;
                    width: 30%; /* Adjust width as needed */
                    text-align: right;
                }
                .qr-code img {
                    max-height: 120px;
                }
                table {
                    width: 100%;
                    border-collapse: collapse;
                }
                th, td {
                    border: 1px solid black;
                    padding: 8px;
                    text-align: left;
                }
            </style>
        </head>
        <body>
            <header>
                <h1>Clinical Report</h1>
            </header>
            <div class='patient-details'>
                " + getPatientDetails(patientId) + @"
            </div>
            </div>
            <div id='diagonsis-details'>
                <h2>Diagnosis Details</h2>
                <p><strong>Diagnosis:</strong> " + diagnosisModel.AutoDiagnosis + @"</p>
                <p><strong>Comments:</strong>  " + diagnosisModel.Comments + @"</p>
            </div>
            <br />
            <div class='prescription-details'>
                <h2>Prescription Details</h2>
                <table id='items'>
                    <thead>
                        <tr>
                            <th>*</th>
                            <th>Drug Name</th>
                            <th>Dose</th>
                            <th>Instructions</th>
                        </tr>
                    </thead>
                    <tbody>" + createPrescriptionTabel(prescriptionData) + @"
                    </tbody>
                </table>
            </div>
            <footer>
                <p>Thank you for your business!</p>
            </footer>
        </body>
        </html>";

        }

        string createPrescriptionTabel(DataTable prescriptionData) {
            string prescriptionTable = "";
            foreach (DataRow test in prescriptionData.Rows)
            {
                prescriptionTable += @"<tr>
                            <td></td>
                            <td>" + test[0] + @"</td>
                            <td>" + test[1] + @"</td>
                        </tr>";
            }

            return prescriptionTable;
        }

        public void openPDFfile()
        {
            string filePath = Application.StartupPath + @"\data\export.pdf"; 

            try
            {
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
