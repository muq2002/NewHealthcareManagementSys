using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Config;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Controller
{
    class PatientController
    {
        DatabaseProvider databaseProvider = new DatabaseProvider();
        public string DeleteStatus = "No";


        public PatientController() { }
        public DataTable readPatients()
        {
            return databaseProvider.getTable("SELECT * FROM Patients" +
                " WHERE [DeleteStatus]='" + DeleteStatus + "' ORDER BY ID ASC");
        }


        public DataTable getSinglePatient(int patientId)
        {
            return databaseProvider.getTable("SELECT * FROM Patients" +
                " WHERE ([ID] = " + patientId  + " AND [DeleteStatus]='" + DeleteStatus + "') " +
                "ORDER BY ID ASC");
        }
        public DataTable getPatientNames()
        {
            return databaseProvider.getTable("SELECT PatientID, Uuid, PatientName FROM Patients" +
                " WHERE [DeleteStatus]='" + DeleteStatus + "' ORDER BY PatientID ASC");
        }
        public DataTable readPatients(int limit = 100)
        {
            return databaseProvider.getTable("SELECT TOP " + limit + " * FROM Patients" +
                " WHERE [DeleteStatus]='" + DeleteStatus + "' ORDER BY PatientID ASC");
        }

        public DataTable searchPatients(string searchText)
        {
            return databaseProvider.getTable("SELECT * FROM Patients" +
                " WHERE ([PatientName] LIKE '" + searchText + "%' " +
                "AND [DeleteStatus]='" + DeleteStatus + "') ORDER BY ID ASC");
        }
        public void createPatient(PatientModel patient)
        {
            string command = "INSERT INTO Patients(" +
                "Uuid," + 
                "PatientName," +
                "PatientAge," +
                "PatientGender," +
                "PatientPhoneNumber, " + 
                "RegisterDate," +
                "DeleteStatus" +
                ") " +
                "VALUES(" +
                 patient.PatientUUID + ", '" + 
                 patient.PatientName + "', " +
                 patient.PatientAge + ", " +
                 patient.PatientGender + ",'" +
                 patient.PatientPhoneNumber + "', '" +
                 DateTime.Now + "' , 'No'" +
                ")";
            databaseProvider.runCommand(command);
        }
        public void updatePatient(PatientModel patient)
        {
            string command = "UPDATE Patients SET " +
            "[Uuid] = " + patient.PatientUUID + ", " +
            "[PatientName] = '" + patient.PatientName + "', " +
            "[PatientAge] = " + patient.PatientAge + ", " +
            "[PatientGender] = " + patient.PatientGender + ", " +
            "[PatientPhoneNumber] = '" + patient.PatientPhoneNumber + "' " +
            "WHERE ID=" + patient.PatientID;

            databaseProvider.runCommand(command);
        }
        public void deletePatient(int patientId)
        {
            string command = "UPDATE Patients SET " +
                "[DeleteStatus] = 'Yes' WHERE ID=" + patientId;

            databaseProvider.runCommand(command);
        }

        public void restorePatient(int patientId)
        {
            string command = "UPDATE Patients SET " +
                "[DeleteStatus] = 'No' WHERE ID=" + patientId;

            databaseProvider.runCommand(command);
        }
    }
}
