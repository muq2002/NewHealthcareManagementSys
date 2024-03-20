using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareManagementSystem.Controller;
using HealthcareManagement.Controller;

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
            loadAnalysisGroup(testGroupController.readTestGroups());
            fillTestsData(testsBankController.readTestsBank());
            fillDevicesData(devicesController.readDevices());
        }

        void fillTestsData(DataTable patientData)
        {
            dataTests.Rows.Clear();
            for (int index = 0; index < patientData.Rows.Count; index++)
            {
                //int.TryParse(patientData.Rows[index][2].ToString(), out int parsedValue);

                string[] data = new string[] {
                    patientData.Rows[index][0].ToString(),
                    "",
                    patientData.Rows[index][1].ToString(),
                };
                dataTests.Rows.Add(data);
                dataTests.Rows[index].Cells[1].Value = false;
            }
        }
        private void loadAnalysisGroup(DataTable groupAnalysis)
        {
            listAnalysisGroup.ValueMember = "ID";
            listAnalysisGroup.DisplayMember = "GroupName";
            listAnalysisGroup.DataSource = groupAnalysis;

        }

        private void picAddNewGruop_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < dataTests.Rows.Count - 1; index++)
            {
                if ((bool)dataTests.Rows[index].Cells[1].Value != true) continue;
                //testGroupController.updataGroup();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fillTestsData(testsBankController.readTestsBank());
        }

        private void listAnalysisGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listAnalysisGroup.SelectedIndex;

            if (selectedIndex == -1) return;
            fillTestsData(testsBankController.getSingleTestGroups(selectedIndex.ToString()));
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
    }
}
