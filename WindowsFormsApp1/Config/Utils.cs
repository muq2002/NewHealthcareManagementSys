using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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

        public static string crateUUID() {
            Guid uuid = Guid.NewGuid();
            string md5Hash = ComputeMD5Hash(uuid.ToString());
            return md5Hash.Substring(0, 8).ToUpper();
        }

    private static string ComputeMD5Hash(string input)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }

        public static string extractText(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;
            return Regex.Replace(input, "[^a-zA-Z\\s]", "");
        }

        public static bool isString(string input )
        {
            if (string.IsNullOrEmpty(input))
                return false;
            return Regex.IsMatch(input, "[^a-zA-Z\\s]");
        }


    }
}
