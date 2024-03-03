﻿using System;
using System.Data;
using System.Windows.Forms;
using HealthcareManagementSystem.Controller;


namespace HealthcareManagementSystem.UserControls.Pharmacy
{
    public partial class PharmacyDrugList : UserControl
    {
        public PharmacyDrugList()
        {
            InitializeComponent();
        }
        DrugsController drugsController = new DrugsController();
        private void PharmacyDrugList_Load(object sender, EventArgs e)
        {
            fillDrugsData(drugsController.readDrugs());
        }

        void fillDrugsData(DataTable drugDrug)
        {
            dataDrugs.Rows.Clear();
            for (int index = 0; index < drugDrug.Rows.Count; index++)
            {
                string[] data = new string[] {
                    drugDrug.Rows[index][0].ToString(),
                    drugDrug.Rows[index][1].ToString(),
                    drugDrug.Rows[index][2].ToString(),
                    drugDrug.Rows[index][3].ToString(),
                    "", "",
                    drugDrug.Rows[index][7].ToString(),
                };
                dataDrugs.Rows.Add(data);
            }
        }
    }
}
