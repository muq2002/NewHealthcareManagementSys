using HealthcareManagement.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        List<int> selectedTests = new List<int>();
        private void DoctorSelectMedicalTests_Load(object sender, EventArgs e)
        {
            PopulateTreeView();
        }


        private void PopulateTreeView()
        {
            treeView1.Nodes.Clear();

            DataTable parentTable = testGroupController.readTestGroups();

            foreach (DataRow parentRow in parentTable.Rows)
            {
                TreeNode parentNode = new TreeNode(parentRow["GroupName"].ToString());
                int parentID = Convert.ToInt32(parentRow["ID"]);
                DataTable subgroupTable = testsBankController.getSingleTestGroups(parentID.ToString());
                foreach (DataRow subgroupRow in subgroupTable.Rows)
                {
                    if (Convert.ToInt32(subgroupRow["GroupRelated"]) == parentID)
                    {
                        TreeNode subgroupNode = new TreeNode(subgroupRow["TestName"].ToString());
                        parentNode.Nodes.Add(subgroupNode);
                    }
                }

                treeView1.Nodes.Add(parentNode);
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                filldataTests(testsBankController.getSingleTestGroups(treeView1.SelectedNode.Text));
            }
        }

        void filldataTests(DataTable dataTest) {
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
                e.RowIndex >= 00 ) && dataTests[e.ColumnIndex, e.RowIndex].Value != null;
        }

        private void sendTestsBTN_Click(object sender, EventArgs e)
        {
            restSelectRow();
            foreach (var item in selectedTests)
            {
                MessageBox.Show(item.ToString());
            }
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

        void restSelectRow() {
            if (dataTests.Rows.Count > 0)
            {
                dataTests.ClearSelection();
                dataTests.Rows[1].Selected = true;
            }

        }
    }
}
