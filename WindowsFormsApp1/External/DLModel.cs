using System;
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
            return getClassOfPrediction(sendPrediction());

        }
        public string sendPredictionForLiverModel(string prompt)
        {
            buildRunTask("liver_model_runner.py", prompt);
            return getClassOfPrediction(sendPrediction());
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

            p.WaitForExit();
            string output = p.StandardOutput.ReadToEnd();
            return output;
        }

        static string getClassOfPrediction(string inputText)
        {
            int index = inputText.IndexOf("step");
            if (index != -1)
            {
                return inputText.Substring(index + 4);
            }
            else
            {
                return ""; // "/step" not found
            }
        }
        void buildRunTask(string model, string prompt)
        {
            string fullPath = Application.StartupPath + "\\ml\\run_task.bat";
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.WriteLine("echo off");
                writer.WriteLine("cd " + Application.StartupPath + "\\ml\\");
                writer.WriteLine(@"python " + model + " " + prompt);
               //writer.WriteLine("timeout 3");
            }
        }
    }
}
