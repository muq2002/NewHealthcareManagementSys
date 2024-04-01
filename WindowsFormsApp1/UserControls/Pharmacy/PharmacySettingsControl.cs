using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthcareManagement.Properties;

namespace HealthcareManagement.Screens.UserControls.Pharmacy
{
    public partial class PharmacySettingsControl : UserControl
    {
        public PharmacySettingsControl()
        {
            InitializeComponent();
        }

        private void PharmacySettingsControl_Load(object sender, EventArgs e)
        {
            laodSettings();
        }

        private void laodSettings()
        {
            comboPortName.Text = Settings.Default.PortName;
            comboBaudRate.Text = Settings.Default.BaudRate;
        }
        private void comboPortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.PortName = comboPortName.Text;
            Settings.Default.Save();
        }

        private void comboBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.BaudRate = comboBaudRate.Text;
            Settings.Default.Save();
        }
    }
}
