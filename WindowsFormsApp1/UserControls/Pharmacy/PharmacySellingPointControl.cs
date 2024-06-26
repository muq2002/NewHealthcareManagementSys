﻿using HealthcareManagement.Config;
using HealthcareManagement.Controller;
using HealthcareManagement.Screens.Model;
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
    public partial class PharmacySellingPointControl : Form
    {
        public PharmacySellingPointControl()
        {
            InitializeComponent();
        }
        public int patientId { get; set; }
        int totalPrice = 0;
        PrescriptionController prescriptionController = new PrescriptionController();

        private void PharmacySellingPointControl_Load(object sender, EventArgs e)
        {
            fillPrescriptionsData(prescriptionController
                .getPrescriptionWithPriceByPatientId(patientId));
            createChart();
            calculatePrices();
        }
        void fillPrescriptionsData(DataTable drugDrug)
        {
            dataDrugs.Rows.Clear();
            for (int index = 0; index < drugDrug.Rows.Count; index++)
            {
                string[] data = new string[] {
                    drugDrug.Rows[index][0].ToString(),
                    drugDrug.Rows[index][4].ToString(),
                    drugDrug.Rows[index][5].ToString(),
                    "1",
                    drugDrug.Rows[index][6].ToString(),
                };
                dataDrugs.Rows.Add(data);
            }
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void createChart()
        {
            for (int index = 0; index < dataDrugs.Rows.Count; index++)
            {
                summaryChart.Series[0].Points.AddXY(
                    dataDrugs.Rows[index].Cells[1].Value.ToString(),
                    int.Parse(dataDrugs.Rows[index].Cells[2].Value.ToString())
                    );
            }
        }

        void calculatePrices()
        {
            for (int index = 0; index < dataDrugs.Rows.Count; index++)
            {
                totalPrice += int.Parse(dataDrugs.Rows[index].Cells[2].Value.ToString()) 
                    * int.Parse(dataDrugs.Rows[index].Cells[3].Value.ToString());
            }
            textTotalPrice.Text = totalPrice.ToString();
            textRequestPrice.Text = textTotalPrice.Text;
        }

        private void textPayOffPrice_TextChanged(object sender, EventArgs e)

        {
            // Check if all characters in the text box are digits
            bool allDigits = textPayOffPrice.Text.All(char.IsDigit);

            if (!allDigits) textPayOffPrice.Text = "0"; 

            if (textPayOffPrice.Text == "") textPayOffPrice.Text = "0";
            textRequestPrice.Text = (int.Parse(textTotalPrice.Text) 
                - int.Parse(textPayOffPrice.Text)).ToString(); 

        }

        private void paymentBTN_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPrinter myPrinter = new MyPrinter();

            HTMLDocument.createHtmltoPdf(myPrinter
                .createHTMLFileForPharmacy(patientId, fillDrugs()));
            myPrinter.openPDFfile();
        }

        DataTable fillDrugs()
        {
            DataTable result = new DataTable();

            foreach (DataGridViewColumn column in dataDrugs.Columns)
            {
                result.Columns.Add(column.Name, typeof(string));
            }

            foreach (DataGridViewRow row in dataDrugs.Rows)
            {
                DataRow newRow = result.NewRow();

                newRow[0] = row.Cells[1].Value.ToString();
                newRow[1] = row.Cells[3].Value.ToString();
                newRow[2] = row.Cells[2].Value.ToString();
                newRow[3] = row.Cells[4].Value.ToString();

                result.Rows.Add(newRow);
            }
            return result;
        }


    }
}
