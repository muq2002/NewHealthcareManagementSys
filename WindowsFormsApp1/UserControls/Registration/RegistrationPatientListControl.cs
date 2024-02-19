using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Config;

namespace WindowsFormsApp1.UserControls.Registration
{
    public partial class RegistrationPatientListControl : UserControl
    {
        public RegistrationPatientListControl()
        {
            InitializeComponent();
        }

        private void RegistrationPatientListControl_Load(object sender, EventArgs e)
        {
            Utils.CenterItemsInPanel(panel2);
            Utils.CenterItemsInPanel(panel4);
            Utils.CenterItemsInPanel(panel11);
            Utils.CenterItemsInPanel(panel12);
        }

        
    }
}
