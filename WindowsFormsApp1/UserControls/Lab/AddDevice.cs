using HealthcareManagement.Controller;
using HealthcareManagement.Model;
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
    public partial class AddDevice : Form
    {
        public AddDevice()
        {
            InitializeComponent();
        }
        DevicesController devicesController = new DevicesController();
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addDeviceBTN_Click(object sender, EventArgs e)
        {
            DeviceModel deviceMddel = new DeviceModel
            {
                DeviceName = textDeviceName.Text,
                IP = textIP.Text
            };

            devicesController.createDevice(deviceMddel);
            this.Close();
        }
    }
}
