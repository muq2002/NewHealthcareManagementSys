using HealthcareManagement.Model;
using HealthcareManagement.Screens.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareManagement.Controller
{
    class UserController
    {

        DatabaseProvider databaseProvider = new DatabaseProvider();
        public string DeleteStatus = "No";


        public UserController() { }
        public DataTable readUsers()
        {
            return databaseProvider.getTable("SELECT * FROM Users" +
                " WHERE [DeleteStatus]='" + DeleteStatus + "' ORDER BY ID ASC");
        }

        public DataTable getSingleUser(int patientId)
        {
            return databaseProvider.getTable("SELECT * FROM Users" +
                " WHERE ([ID] = " + patientId + " AND [DeleteStatus]='" + DeleteStatus + "') " +
                "ORDER BY ID ASC");
        }

        public void createUser(UserModel user)
        {
            string command = "INSERT INTO Users(" +
                "Username," +
                "Password," +
                "Permission," +
                "RegisterDate," +
                "DeleteStatus" +
                ") " +
                "VALUES('" +
                 user.Username + "', '" +
                 user.Password + "', '" +
                 user.Permission + "', " +
                 DateTime.Now + "' , 'No'" +
                ")";
            databaseProvider.runCommand(command);
        }
        public void updateUser(UserModel user)
        {
            string command = "UPDATE Users SET " +
            "[Username] = '" + user.Username + "', " +
            "[Password] = '" + user.Password + "', " +
            "[Permission] = '" + user.Permission + "', " +
            "WHERE ID=" + user.ID;

            databaseProvider.runCommand(command);
        }
        public void deleteUser(int userId)
        {
            string command = "UPDATE Users SET " +
                "[DeleteStatus] = 'Yes' WHERE ID=" + userId;

            databaseProvider.runCommand(command);
        }

        public void restoreUser(int userId)
        {
            string command = "UPDATE Users SET " +
                "[DeleteStatus] = 'No' WHERE ID=" + userId;

            databaseProvider.runCommand(command);
        }
    }
}
