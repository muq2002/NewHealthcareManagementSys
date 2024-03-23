using HealthcareManagement.Controller;
using HealthcareManagementSystem.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthcareManagement.UserControls.Lab
{
    public partial class AddSubGroup : Form
    {
        public AddSubGroup()
        {
            InitializeComponent();
        }
        TestGroupController testGroupController = new TestGroupController();
        public string SubGroupName { get; set; }
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void addGroupBTN_Click(object sender, EventArgs e)
        {
            //if (!Utils.isString(textGroupName.Text)) return;
            testGroupController.createSubGroup(textGroupName.Text);
            SubGroupName = textGroupName.Text;
            MessageBox.Show("The Group has been added successfully!");
            this.Close();
        }
    }
}
