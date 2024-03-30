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

namespace HealthcareManagement.Screens.UserControls
{
    public partial class TestsListControl : UserControl
    {
        public TestsListControl()
        {
            InitializeComponent();
        }
        TestController testController = new TestController();
        DevicesController deviceController = new DevicesController();

        private void TestsListControl_Load(object sender, EventArgs e)
        {
            createListTests();
            getIncompleteTests(testController.readTests(100));
           

        }

        void createListTests() {

            DataGridViewTextBoxColumn Col1 = new DataGridViewTextBoxColumn();
            Col1.HeaderText = "ID";
            Col1.Width = 60;

            DataGridViewTextBoxColumn Col2 = new DataGridViewTextBoxColumn();
            Col2.HeaderText = "Patient Name";
            Col2.Width = 200;

            DataGridViewTextBoxColumn Col3 = new DataGridViewTextBoxColumn();
            Col3.HeaderText = "Test Name";
            Col3.Width = 300;

            DataGridViewComboBoxColumn Col4 = new DataGridViewComboBoxColumn();
            Col4.HeaderText = "Device Name";
            Col4.Width = 200;

            Col4.DataPropertyName = "ID";
            Col4.DisplayMember = "DeviceName";
            Col4.ValueMember = "ID";
            Col4.DataSource = deviceController.readDevices();

            dataTests.Columns.Add(Col1);
            dataTests.Columns.Add(Col2);
            dataTests.Columns.Add(Col3);
            dataTests.Columns.Add(Col4);
        }

        void getIncompleteTests(DataTable patientData)
        {
            dataTests.Rows.Clear();
            for (int index = 0; index < patientData.Rows.Count; index++)
            {
                if (!String.IsNullOrEmpty(patientData.Rows[index][5].ToString())) { continue; }
                string[] data = new string[] {
                    patientData.Rows[index][0].ToString(),
                    patientData.Rows[index][2].ToString(),
                    patientData.Rows[index][4].ToString(),
                    
                };
                dataTests.Rows.Add(data);
            }
        }

        private void textSearch_OnTextChange(object sender, EventArgs e)
        {
            if(textSearch.text == "") getIncompleteTests(testController.readTests(100));
            getIncompleteTests(testController.saerchPatientsTests(100, textSearch.text));
        }
    }
}
