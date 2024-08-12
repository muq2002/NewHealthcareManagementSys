using System;
using System.Data;
using System.Windows.Forms;
using HealthcareManagement.Config;
using HealthcareManagement.Screens.Controller;
using HealthcareManagement.Screens.Model;

namespace HealthcareManagement.UserControls.Lab
{
    public partial class LabPatientProfileControl : UserControl
    {
        public LabPatientProfileControl()
        {
            InitializeComponent();
        }

        public int patientId { get; set; }
        TestController testController = new TestController();

        private void LabPatientProfile_Load(object sender, EventArgs e)
        {

        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int index =0; index  < dataTests.Rows.Count; index++)
            {
                testController.updateTest(createTestModel(index));
            }
        }

        private TestModel createTestModel(int index)
        {
            TestModel testModel = new TestModel();
            testModel.ID = int.Parse(dataTests.Rows[index]
                .Cells[0].Value.ToString());
            testModel.TestValue = dataTests.Rows[index].Cells[2].Value.ToString();
            testModel.Comment = dataTests.Rows[index].Cells[4].Value.ToString();
            testModel.PatientID = patientId;
            return testModel;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MyPrinter myPrinter = new MyPrinter();

            HTMLDocument.createHtmltoPdf(myPrinter
                .createHTMLFileForLab(new PatientModel(), fillTests()));
            myPrinter.openPDFfile();
        }

        DataTable fillTests()
        {
            DataTable result = new DataTable();

            foreach (DataGridViewColumn column in dataTests.Columns)
            {
                result.Columns.Add(column.Name, typeof(string));
            }

            foreach (DataGridViewRow row in dataTests.Rows)
            {
                DataRow newRow = result.NewRow();

                newRow[0] = row.Cells[0].Value.ToString();
                newRow[1] = row.Cells[1].Value.ToString();
                newRow[2] = row.Cells[2].Value.ToString();
                newRow[3] = row.Cells[3].Value.ToString();

                result.Rows.Add(newRow);
            }
            return result;
        }

    }
}
