using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareManagement.Screens.Config;
using HealthcareManagement.Screens.Controller;

namespace HealthcareManagement.Screens.Screens
{
    public partial class LabHomeControl : UserControl
    {
        public LabHomeControl()
        {
            InitializeComponent();
        }

        PatientController patientController = new PatientController();
       
        private void HomeControl_Load(object sender, EventArgs e)
        {
            CenterItemsInPanel(panel2);
            CenterItemsInPanel(panel4);
            CenterItemsInPanel(panel5);

            fillPatientData(patientController.readPatients());
            updateTheDate();
        }
        private void updateTheDate()
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dddd, MMMM d, yyyy");

            dateLabel1.Text = formattedDate;
            dateLabel2.Text = formattedDate;
            dateLabel3.Text = formattedDate;
        }
        void fillPatientData(DataTable patientData)
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
                    patientData.Rows[index][6].ToString(),
                };
                dataPatients.Rows.Add(data);
            }
            calculateStatictis();
        }
        void calculateStatictis()
        {
            totalNumberPatientsLabel.Text = dataPatients.Rows.Count.ToString();
        }
        private void CenterItemsInPanel(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                // Calculate the new location to center the control
                int newX = (panel.Width - control.Width) / 2;
                int newY = (panel.Height - control.Height) / 2;

                // Set the new location for the control
                control.Location = new System.Drawing.Point(newX, control.Location.Y);
            }
        }
    }
}
