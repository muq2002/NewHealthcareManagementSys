using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Screens
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            CenterItemsInPanel(panel2);
            CenterItemsInPanel(panel4);
            CenterItemsInPanel(panel5);
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
