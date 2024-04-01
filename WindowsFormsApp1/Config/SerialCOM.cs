using HealthcareManagement.Properties;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareManagement.Config
{


    class SerialCOM
    {
        public static void writeIntoSerial(string text)
        {
            string portName = Settings.Default.PortName;
            int baudRate = int.Parse(Settings.Default.BaudRate);
            SerialPort serialPort = new SerialPort(portName, baudRate);

            try
            {
                // Open the serial port
                serialPort.Open();
                serialPort.Write(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                serialPort.Close();
            }
        }
    }
}
