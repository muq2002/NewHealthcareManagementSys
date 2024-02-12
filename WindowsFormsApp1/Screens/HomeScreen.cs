using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Screens;
using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TestsListControl testsListControl = new TestsListControl();
        PatientsListControl patientsListControl = new PatientsListControl();

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            testsListControl.Dock = DockStyle.Fill;
            container.Controls.Add(testsListControl);

            patientsListControl.Dock = DockStyle.Fill;
            container.Controls.Add(patientsListControl);
        }

        private void testsListBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            testsListControl.Visible = true;

            testsListBTN.IdleFillColor = Color.White;
            testsListBTN.IdleForecolor = Color.FromArgb(1, 56, 182, 255);

        }

        private void ordersBTN_Click(object sender, EventArgs e)
        {
            convertColor(); hiddenForms();
            homeControl1.Visible = true;

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


        void hiddenForms() {
            homeControl1.Visible = false;
            testsListControl.Visible = false;
            patientsListControl.Visible = false;
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
