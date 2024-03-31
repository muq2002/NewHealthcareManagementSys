using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace HealthcareManagement.External
{
    class DLModel
    {

        public string sendPredictionForKidneyModel(string prompt)
        {
            buildRunTask("kidney_model_runner.py", prompt);
            return sendPrediction();
        }
        public string sendPredictionForLiverModel(string prompt)
        {
            buildRunTask("liver_model_runner.py", prompt);
            return sendPrediction();
        }
        string sendPrediction()
        {

            Process p = new Process();
            p.StartInfo.FileName = "C:\\Windows\\system32\\cmd.exe";
            p.StartInfo.Arguments = "/C " + Application.StartupPath + "\\ml\\run_task.bat";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = false;
            p.StartInfo.UseShellExecute = false;
            p.Start();

            string d = p.StandardOutput.ReadToEnd();
            
            p.WaitForExit();
            return d;
        }

        void buildRunTask(string model, string prompt)
        {
            string fullPath = Application.StartupPath + "\\ml\\run_task.bat";
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.WriteLine("echo off");
                writer.WriteLine(@"python .\" + model + " " + prompt);
                writer.WriteLine("timeout 3");
            }
        }
    }
}
