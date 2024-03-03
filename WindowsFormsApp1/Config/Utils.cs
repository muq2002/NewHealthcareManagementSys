using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthcareManagementSystem.Config
{
    public class Utils
    {
        public static void changeColor(int index, Panel sidebar)
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

        public static void CenterItemsInPanel(Panel panel)
        {
            if (panel == null)
                return;

            int totalHeight = 0;

            foreach (Control control in panel.Controls)
            {
                totalHeight += control.Height;
            }

            int centerY = (panel.Height - totalHeight) / 2;

            int currentY = centerY;

            foreach (Control control in panel.Controls)
            {
                int centerX = (panel.Width - control.Width) / 2;
                control.Location = new System.Drawing.Point(centerX, control.Location.Y);
            }
        }

        public static string getGenderStr(string gender)
        {
            if (gender == "1") return "Male";
            return "Female";
        }

    }
}
