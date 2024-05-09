using HealthcareManagement.Screens.Controller;
using HealthcareManagement.Screens.Model;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace HealthcareManagement.Screens.OperationsLab
{
    public partial class OperationsLabScreen : Form
    {
        private TestController testController = new TestController();
        public OperationsLabScreen()
        {
            InitializeComponent();
        }

        private void OperationsLabScreen_Load(object sender, EventArgs e)
        {
            createListTests();
            getIncompleteTests(testController.readTests(100));
        }

        private void getIncompleteTests(DataTable patientData)
        {
            dataTests.Rows.Clear();
            for (int index = 0; index < patientData.Rows.Count; index++)
            {
                if (!String.IsNullOrEmpty(patientData.Rows[index][5].ToString())) { continue; }
                string[] data = new string[] {
                    patientData.Rows[index][0].ToString(),
                    patientData.Rows[index][1].ToString(),
                    patientData.Rows[index][2].ToString(),
                    patientData.Rows[index][4].ToString(),
                    patientData.Rows[index][5].ToString(),

                };
                dataTests.Rows.Add(data);
            }
        }


        private void createListTests()
        {

            DataGridViewTextBoxColumn Col1 = new DataGridViewTextBoxColumn();
            Col1.HeaderText = "ID";
            Col1.Width = 60;



            DataGridViewTextBoxColumn Col2 = new DataGridViewTextBoxColumn();
            Col2.HeaderText = "Patient Name";
            Col2.Width = 200;

            DataGridViewTextBoxColumn Col3 = new DataGridViewTextBoxColumn();
            Col3.HeaderText = "Test Name";
            Col3.Width = 300;

            DataGridViewTextBoxColumn Col4 = new DataGridViewTextBoxColumn();
            Col4.HeaderText = "Value";
            Col4.Width = 200;

            DataGridViewTextBoxColumn Col5 = new DataGridViewTextBoxColumn();
            Col5.HeaderText = "Patient ID";
            Col5.Width = 60;
            Col5.Visible = false;


            dataTests.Columns.Add(Col1);
            dataTests.Columns.Add(Col5);
            dataTests.Columns.Add(Col2);
            dataTests.Columns.Add(Col3);
            dataTests.Columns.Add(Col4);
        }

        private void openPDFBTN_Click(object sender, EventArgs e)
        {
            string path = getPathOfFile();
            if (path == "")
            {
                return;
            }
            runScript(path);
            OpenCSVFile openCSVFile = new OpenCSVFile();
            openCSVFile.ShowDialog();

            for (int index = 0; index < openCSVFile.tests.Count - 1; index ++)
            {
                dataTests.Rows[index].Cells[5].Value = openCSVFile.tests[index];
            }
        }

        private string getPathOfFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a file";
            openFileDialog.Filter = "All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }

            return "";
        }

        private void runScript(string filename)
        {
            string scriptPath = Application.StartupPath + "\\config\\convert_pdf_excel.py";
            MessageBox.Show(scriptPath);
            try
            {
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = scriptPath + " " + filename,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    WorkingDirectory = Environment.CurrentDirectory
                };
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                MessageBox.Show(output);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void logoutBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataSendBTN_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < dataTests.Rows.Count; index++)
            {
                if (dataTests.Rows[index].Cells[4].Value != null
                    && !string.IsNullOrEmpty(dataTests.Rows[index].Cells[4].Value.ToString()))
                {
                    testController.updateTest(createTestModel(index));
                }
            }

            getIncompleteTests(testController.readTests(100));
        }
        private TestModel createTestModel(int index)
        {
            TestModel testModel = new TestModel();
            testModel.ID = int.Parse(dataTests.Rows[index]
                .Cells[0].Value.ToString());
            testModel.TestValue = dataTests.Rows[index].Cells[4].Value.ToString();
            testModel.Comment = "";
            testModel.PatientID = int.Parse(dataTests.Rows[index].Cells[1].Value.ToString());
            return testModel;
        }

    }
}
