using HealthcareManagement.Controller;
using HealthcareManagement.Screens.Config;
using HealthcareManagement.Screens.Controller;
using HealthcareManagement.Screens.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HealthcareManagement.UserControls.Doctor
{
    public partial class DoctorSelectMedicalTests : Form
    {
        public DoctorSelectMedicalTests()
        {
            InitializeComponent();
        }
        TestGroupController testGroupController = new TestGroupController();
        TestsBankController testsBankController = new TestsBankController();
        TestController testController = new TestController();
        SessionController sessionController = new SessionController();
        List<int> selectedTests = new List<int>();

        public int patientId { get; set; }
        public int sessionId { get; set; }
        private void DoctorSelectMedicalTests_Load(object sender, EventArgs e)
        {
            loadAnalysisGroup();
        }


        private void loadAnalysisGroup()
        {
            treeView1.Nodes.Clear();
            DataTable parentTable = testGroupController.getGroupNames();


            foreach (DataRow parentRow in parentTable.Rows)
            {
                TreeNode parentNode = new TreeNode(parentRow["GroupName"].ToString());
                treeView1.Nodes.Add(parentNode);

                DataTable bufferTableWithCounts = testGroupController
                    .getSubGroupNames(int.Parse(parentRow["ID"].ToString()));


                foreach (DataRow childRow in bufferTableWithCounts.Rows)
                {
                    addNodeTree(parentNode, childRow);

                }
            }
        }
        private void addNodeTree(TreeNode parentNode, DataRow childRow)
        {
            DataTable dataSubGroupName = testGroupController
                .getSingleSubGroupNames(int.Parse(childRow["SubGroupID"].ToString()));
            parentNode.Nodes.Add(new TreeNode(dataSubGroupName.Rows[0]["SubGroupName"].ToString()
                + " (" + childRow["Expr1"] + ")"));
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (treeView1.SelectedNode == null) return;
            fillTestsDataForTree(testsBankController
               .getSingleTestsBySubGroups(getSubGroupId(treeView1.SelectedNode.Text)));
        }

        int getSubGroupId(string SubGroupName)
        {
            DataTable subGroupTests = testGroupController
            .getSingleSubGroupNames(Utils.extractText(SubGroupName));
            if (subGroupTests.Rows.Count == 0) return 0;
            return int.Parse(subGroupTests.Rows[0]["ID"].ToString());

        }
        void fillTestsDataForTree(DataTable testData)
        {
            dataTests.Rows.Clear();
            for (int index = 0; index < testData.Rows.Count; index++)
            {
                string[] data = new string[] {
                    testData.Rows[index][2].ToString(),
                    testData.Rows[index][4].ToString(),
                };
                dataTests.Rows.Add(data);
            }
        }

        void filldataTests(DataTable dataTest)
        {
            dataTests.Rows.Clear();
            for (int index = 0; index < dataTest.Rows.Count; index++)
            {
                string[] data = new string[] {
                    dataTest.Rows[index][0].ToString(),
                    dataTest.Rows[index][1].ToString(),
                };
                dataTests.Rows.Add(data);
            }


        }

        private bool isUserSelectStatus(DataGridViewCellEventArgs e)
        {
            return (e.ColumnIndex == 2 &&
                e.RowIndex >= 00) && dataTests[e.ColumnIndex, e.RowIndex].Value != null;
        }

        private void sendTestsBTN_Click(object sender, EventArgs e)
        {
            //foreach (var item in selectedTests)
            //{
            //    createTestModel(item);
            //}
            // Send through serial
            string message = @"{""from"": ""doc"", ""to"": ""lab"", ""patientId"": " + patientId.ToString()
            + @", ""sessionId"": " + sessionId.ToString() + @", ""sessionName"": """ +
            sessionController.getSingleSessionName(sessionId) + @""",""data"":[" + testsToJsonText() + "]}";

            MessageBox.Show(message);
            this.Close();
        }
        string testsToJsonText()
        {
            string buffer = ""; int counter = 0;
            foreach (var item in selectedTests)
            {
                string temp = @"{ ""testId"": " + item
                            + @", ""value"": """"},";
                if (counter == selectedTests.Count - 1)
                {
                    temp = @"{ ""testId"": " + item
                           + @", ""value"": """"}";
                }


                buffer += temp;
                counter++;
            }
            return buffer;

        }
        private void createTestModel(int item)
        {
            TestModel testModel = new TestModel();

            testModel.PatientID = patientId;
            testModel.SessionID = sessionId;
            testModel.TestID = item;

            testModel.TestValue = "";
            testModel.Comment = "";

            testController.createTest(testModel);


        }

        private void dataTests_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!isUserSelectStatus(e)) return;
            if ((bool)dataTests[e.ColumnIndex, e.RowIndex].Value)
            {
                selectedTests.Add(int.Parse(dataTests[0, e.RowIndex].Value.ToString()));
            }
            else
            {
                selectedTests.Remove(int.Parse(dataTests[0, e.RowIndex].Value.ToString()));
            }
        }

        void restSelectRow()
        {
            if (dataTests.Rows.Count > 0)
            {
                dataTests.ClearSelection();
                dataTests.Rows[1].Selected = true;
            }

        }
    }
}