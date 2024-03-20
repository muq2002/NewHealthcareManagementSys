using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace HealthcareManagement.External
{
    class DLModel
    {

        public string sendPredictionForKidneyModel(string[] data) { return ""; }
        public string sendPredictionForLiverModel(string[] data) { return ""; }
        string sendPrediction(string imagePath = "")
        {
            string script = Application.StartupPath + "\\config\\runTask.bat";

            Process p = new Process();
            p.StartInfo.FileName = "C:\\Windows\\system32\\cmd.exe";
            p.StartInfo.Arguments = "/C " + script;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = false;
            p.StartInfo.UseShellExecute = false;
            p.Start();

            p.WaitForExit();
            string output = p.StandardOutput.ReadToEnd();
            return output;
        }

        void buildRunTask(string imagePath)
        {
            string fullPath = Application.StartupPath + "\\config\\runTask.bat";
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.WriteLine("echo off");
                writer.WriteLine("cd " + Application.StartupPath + "\\config\\");
                writer.WriteLine("python detection_model.py " + imagePath);
                writer.WriteLine("timeout 3");
            }
        }
    }
}
