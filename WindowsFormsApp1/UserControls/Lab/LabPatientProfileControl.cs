using System;
using System.Windows.Forms;
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
            for (int index =0; index  < dataTests.Rows.Count -1; index++)
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
    }
}
