using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareManagement.Screens.Controller;
using HealthcareManagement.Controller;
using HealthcareManagement.Screens.Config;
using HealthcareManagement.Properties;

namespace HealthcareManagement.UserControls.Lab
{
    public partial class LabSettingsControl : UserControl
    {
        public LabSettingsControl()
        {
            InitializeComponent();
        }
        TestsBankController testsBankController = new TestsBankController();
        TestGroupController testGroupController = new TestGroupController();
        DevicesController devicesController = new DevicesController();


        private void LabSettingsControl_Load(object sender, EventArgs e)
        {
            loadAnalysisGroup();
            //fillTestsData(testsBankController.readTestsBank());
            fillDevicesData(devicesController.readDevices());
            laodSettings();
        }

        private void laodSettings()
        {
            comboPortName.Text = Settings.Default.PortName;
            comboBaudRate.Text = Settings.Default.BaudRate;
        }

        void fillTestsDataFromAll(DataTable testData)
        {
            dataTests.Rows.Clear();
            for (int index = 0; index < testData.Rows.Count; index++)
            {
                string[] data = new string[] {
                    testData.Rows[index][0].ToString(),
                    "",
                    testData.Rows[index][1].ToString(),
                };
                dataTests.Rows.Add(data);
                dataTests.Rows[index].Cells[1].Value = false;
            }
        }
        void fillTestsDataForTree(DataTable testData)
        {
            dataTests.Rows.Clear();
            for (int index = 0; index < testData.Rows.Count; index++)
            {
                string[] data = new string[] {
                    testData.Rows[index][2].ToString(),
                    "",
                    testData.Rows[index][4].ToString(),
                };
                dataTests.Rows.Add(data);
                dataTests.Rows[index].Cells[1].Value = false;
            }
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

        private void picAddNewGruop_Click(object sender, EventArgs e)
        {
            AddSubGroup addSubGroup = new AddSubGroup();
            addSubGroup.ShowDialog();
            int createdGroupId = getSubGroupId(addSubGroup.SubGroupName);

            for (int index = 0; index < dataTests.Rows.Count - 1; index++)
            {
                if ((bool)dataTests.Rows[index].Cells[1].Value != true) continue;
                testGroupController.addTestsToCustomSubGroup(createdGroupId, int.Parse(dataTests
                    .Rows[index].Cells[0].Value.ToString()));
            }

            loadAnalysisGroup();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fillTestsDataFromAll(testsBankController.readTestsBank());
        }

        private void listAnalysisGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int selectedIndex = listAnalysisGroup.SelectedIndex;

            //if (selectedIndex == -1) return;
            //fillTestsData(testsBankController.getSingleTestGroups(selectedIndex +1));
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDevice addDevice = new AddDevice();
            addDevice.ShowDialog();
            fillDevicesData(devicesController.readDevices());
        }

        void fillDevicesData(DataTable deviceData)
        {
            dataDevices.Rows.Clear();
            for (int index = 0; index < deviceData.Rows.Count; index++)
            {
                string[] data = new string[] {
                    deviceData.Rows[index][0].ToString(),
                    deviceData.Rows[index][1].ToString(),
                    deviceData.Rows[index][2].ToString(),
                };
                dataDevices.Rows.Add(data);

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataDevices.SelectedRows.Count == 0) return;
            devicesController.deleteDevice(int
                .Parse(dataDevices.SelectedRows[0].Cells[0].Value.ToString()));

        }

        private void refreshDataDevicesStripMenuItem_Click(object sender, EventArgs e)
        {
            fillDevicesData(devicesController.readDevices());
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

        private void comboPortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.PortName = comboPortName.Text;
            Settings.Default.Save();
        }

        private void comboBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.BaudRate = comboBaudRate.Text;
            Settings.Default.Save();
        }
    }
}
