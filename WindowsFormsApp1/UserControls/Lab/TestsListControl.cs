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

namespace HealthcareManagementSystem.UserControls
{
    public partial class TestsListControl : UserControl
    {
        public TestsListControl()
        {
            InitializeComponent();
        }
        TestController testController = new TestController();

        private void TestsListControl_Load(object sender, EventArgs e)
        {
            getIncompleteTests(testController.readTests(100));
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
    }
}
