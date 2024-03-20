using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareManagementSystem.Screens;

namespace HealthcareManagementSystem
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }


        #region Controls
        private void loginBTN_Click(object sender, EventArgs e)
        {
            loginEvent();
        }

        private void loginEvent()
        {
            if (textUsername.Text == "lab")
            {
                LabHomeScreen labHomeScreen = new LabHomeScreen();
                labHomeScreen.ShowDialog();
            }
            if (textUsername.Text == "doc")
            {
                DoctorHomeScreen doctorHomescreen = new DoctorHomeScreen();
                doctorHomescreen.ShowDialog();
            }
            if (textUsername.Text == "reg")
            {
                RegistrationHomeScreen registrationHomeScreen = new RegistrationHomeScreen();
                registrationHomeScreen.ShowDialog();
            }
            if (textUsername.Text == "pha")
            {
                PharmacyHomeScreen pharmacyHomeScreen = new PharmacyHomeScreen();
                pharmacyHomeScreen.ShowDialog();
            }
        }

        #endregion

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginEvent();
            }
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
