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
    class SessionController
    {

        DatabaseProvider databaseProvider = new DatabaseProvider();
        public string DeleteStatus = "No";


        public SessionController() { }
        public DataTable readSessions()
        {
            return databaseProvider.getTable("SELECT * FROM Sessions" +
                " WHERE [DeleteStatus]='" + DeleteStatus + "' ORDER BY ID ASC");
        }


        public DataTable getSingleSession(int patientId)
        {
            return databaseProvider.getTable("SELECT * FROM Sessions" +
                " WHERE ([PatientID] = " + patientId + " AND [DeleteStatus]='" + DeleteStatus + "') " +
                "ORDER BY ID ASC");
        }

        public void createSession(SessionModel session)
        {
            string command = "INSERT INTO Sessions(" +
                "PatientID," +
                "SessionName," +
                "RegisterDate," +
                "DeleteStatus" +
                ") " +
                "VALUES(" +
                 session.PatientID + ", '" +
                 session.SessionName + "', '" +
                 DateTime.Now + "' , 'No'" +
                ")";
            databaseProvider.runCommand(command);
        }
        //public void updatePatient(DrugModel patient)
        //{
        //    string command = "UPDATE Patients SET " +
        //    "[Uuid] = " + patient.PatientUUID + ", " +
        //    "[PatientName] = '" + patient.PatientName + "', " +
        //    "[PatientAge] = " + patient.PatientAge + ", " +
        //    "[PatientGender] = " + patient.PatientGender + ", " +
        //    "[PatientPhoneNumber] = '" + patient.PatientPhoneNumber + "' " +
        //    "WHERE ID=" + patient.PatientID;

        //    databaseProvider.runCommand(command);
        //}
        public void deleteSession(int sessionId)
        {
            string command = "UPDATE Sessions SET " +
                "[DeleteStatus] = 'Yes' WHERE ID=" + sessionId;

            databaseProvider.runCommand(command);
        }

        public void restoreSession(int sessionId)
        {
            string command = "UPDATE Sessions SET " +
                "[DeleteStatus] = 'No' WHERE ID=" + sessionId;

            databaseProvider.runCommand(command);
        }
    }
}

