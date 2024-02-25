﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Config;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.UserControls.Doctor;

namespace WindowsFormsApp1.UserControls.Registration
{
    public partial class RegistrationPatientListControl : UserControl
    {
        public RegistrationPatientListControl()
        {
            InitializeComponent();
        }
        PatientController patientController = new PatientController();
        private void RegistrationPatientListControl_Load(object sender, EventArgs e)
        {
            fillPatientData(patientController.readPatients());
            centerTextWidgets();
        }

        public void fillPatientData(DataTable patientData)
        {
            dataPatients.Rows.Clear();
            for (int index = 0; index < patientData.Rows.Count; index++)
            {
                string[] data = new string[] {
                    patientData.Rows[index][0].ToString(),
                    patientData.Rows[index][1].ToString(),
                    patientData.Rows[index][2].ToString(),
                    patientData.Rows[index][3].ToString(),
                    Utils.getGenderStr(patientData.Rows[index][4].ToString()),
                    patientData.Rows[index][5].ToString(),
                    patientData.Rows[index][6].ToString(),
                };
                dataPatients.Rows.Add(data);
            }
            calculateStatictis();
        }
        void calculateStatictis()
        {
            totalNumberPatientsLabel.Text = (dataPatients.Rows.Count - 1).ToString();
        }
        private void centerTextWidgets()
        {
            Utils.CenterItemsInPanel(panel2);
            Utils.CenterItemsInPanel(panel4);
            Utils.CenterItemsInPanel(panel11);
            Utils.CenterItemsInPanel(panel12);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isUserSelectedRow()) return;
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.patientId = int.Parse(dataPatients.SelectedRows[0].Cells["_id"].Value.ToString());
            addPatientForm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isUserSelectedRow()) return;
            patientController.deletePatient(int.Parse(dataPatients.SelectedRows[0].Cells["_id"].Value.ToString()));
            fillPatientData(patientController.readPatients());
        }
        private bool isUserSelectedRow()
        {
            return dataPatients.SelectedRows.Count > 0;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillPatientData(patientController.readPatients());
        }
    }
}
