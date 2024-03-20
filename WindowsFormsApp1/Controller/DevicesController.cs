using HealthcareManagement.Model;
using HealthcareManagementSystem.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareManagement.Controller
{
    class DevicesController
    {
        DatabaseProvider databaseProvider = new DatabaseProvider();
        public string DeleteStatus = "No";


        public DevicesController() { }
        public DataTable readDevices()
        {
            return databaseProvider.getTable("SELECT * FROM Devices" +
                " WHERE [DeleteStatus]='" + DeleteStatus + "' ORDER BY ID ASC");
        }


        public void createDevice(DeviceModel device)
        {
            string command = "INSERT INTO Devices(" +
                "DeviceName," +
                "IP," +
                "DeleteStatus" +
                ") " +
                "VALUES('" +
                 device.DeviceName + "', '" +
                 device.IP + "', " + "'No'" +
                ")";
            databaseProvider.runCommand(command);
        }
        public void deleteDevice(int deviceId)
        {
            string command = "UPDATE Devices SET " +
                "[DeleteStatus] = 'Yes' WHERE ID=" + deviceId;

            databaseProvider.runCommand(command);
        }

        public void restoreDevice(int deviceId)
        {
            string command = "UPDATE Devices SET " +
                "[DeleteStatus] = 'No' WHERE ID=" + deviceId;

            databaseProvider.runCommand(command);
        }
    }
}
