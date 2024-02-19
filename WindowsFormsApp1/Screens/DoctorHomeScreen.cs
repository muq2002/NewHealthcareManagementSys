using Bunifu.Framework.UI;
using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.UserControls;
using WindowsFormsApp1.UserControls.Doctor;

namespace WindowsFormsApp1
{
    public partial class DoctorHomeScreen : Form
    {
        public DoctorHomeScreen()
        {
            InitializeComponent();
        }

        TestsListControl testsListControl = new TestsListControl();
        PatientsListControl patientsListControl = new PatientsListControl();
        PatientProfileControl patientProfileControl = new PatientProfileControl();





        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void testsListBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            testsListControl.Visible = true;

            testsListBTN.IdleFillColor = Color.White;
            testsListBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);

        }

        #region Buttons
        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ordersBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            doctorHomeControl1.Visible = true;

            ordersBTN.IdleFillColor = Color.White;
            ordersBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);

        }
        private void patientBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            patientsListControl.Visible = true;

            patientBTN.IdleFillColor = Color.White;
            patientBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);
        }
        private void StatisticsBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            patientProfileControl.Visible = true;

            StatisticsBTN.IdleFillColor = Color.White;
            StatisticsBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);
        }
        #endregion




        void hiddenForms() {
            doctorHomeControl1.Visible = false;
            testsListControl.Visible = false;
            patientsListControl.Visible = false;
            patientProfileControl.Visible = false;
        }
        void convertColor()
        {

            for (int index = 0; index < 8; index++)
            {
                changeColor(index);
            }

        }
        private void changeColor(int index)
        {
            foreach (var item in sidebar.Controls[index].Controls)
            {

                if (item is BunifuThinButton2 button)
                {
                    button.IdleFillColor = Color.FromArgb(56, 182, 255);
                    button.IdleForecolor = Color.White;
                }
            }
        }



    }
}
