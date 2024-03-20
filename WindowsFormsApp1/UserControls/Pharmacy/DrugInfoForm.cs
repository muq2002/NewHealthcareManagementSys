using HealthcareManagementSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthcareManagement.UserControls.Pharmacy
{
    public partial class DrugInfoForm : Form
    {
        public DrugInfoForm()
        {
            InitializeComponent();
        }
        public int drugID = 0;
        DrugsController drugController = new DrugsController();
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrugInfoForm_Load(object sender, EventArgs e)
        {
            DataTable drug = drugController.getSingleDrug(drugID);

            if (drug.Rows.Count == 0) return;
            textTreatmentArea.Text = drug.Rows[0][4].ToString();
            textCompany.Text = drug.Rows[0][5].ToString();
            textTherapeuticArea.Text = drug.Rows[0][6].ToString();
        }
    }
}
