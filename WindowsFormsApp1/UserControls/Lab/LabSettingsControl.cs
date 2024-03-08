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


        private void LabSettingsControl_Load(object sender, EventArgs e)
        {
            loadAnalysisGroup(testGroupController.readTestGroups());
            fillTestsData(testsBankController.readTestsBank());
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
            for(int index = 0; index < dataTests.Rows.Count - 1; index++)
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
    }
}
