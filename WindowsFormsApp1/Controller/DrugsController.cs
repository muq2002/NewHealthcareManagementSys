using System;
using System.Data;
using HealthcareManagement.Screens.Config;
using HealthcareManagement.Screens.Model;

namespace HealthcareManagement.Screens.Controller
{
    class DrugsController
    {
        DatabaseProvider databaseProvider = new DatabaseProvider();
        public string DeleteStatus = "No";


        public DrugsController() { }
        public DataTable readDrugs()
        {
            return databaseProvider.getTable("SELECT * FROM Drugs" +
                " WHERE [DeleteStatus]='" + DeleteStatus + "' ORDER BY ID ASC");
        }

        public DataTable readDrugsNames()
        {
            return databaseProvider.getTable("SELECT ID, DrugName FROM Drugs" +
                " WHERE [DeleteStatus]='" + DeleteStatus + "' ORDER BY ID ASC");
        }

        public DataTable getSingleDrug(int drugID)
        {
            return databaseProvider.getTable("SELECT * FROM Drugs" +
            " WHERE ([ID]= "+ drugID + " AND [DeleteStatus]='" + DeleteStatus + "') ORDER BY ID ASC");
        }
        public DataTable getSinglePatient(int patientId)
        {
            return databaseProvider.getTable("SELECT * FROM Patients" +
                " WHERE ([ID] = " + patientId + " AND [DeleteStatus]='" + DeleteStatus + "') " +
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
        //public void createPatient(DrugModel patient)
        //{
        //    string command = "INSERT INTO Patients(" +
        //        "Uuid," +
        //        "PatientName," +
        //        "PatientAge," +
        //        "PatientGender," +
        //        "PatientPhoneNumber, " +
        //        "RegisterDate," +
        //        "DeleteStatus" +
        //        ") " +
        //        "VALUES(" +
        //         patient.PatientUUID + ", '" +
        //         patient.PatientName + "', " +
        //         patient.PatientAge + ", " +
        //         patient.PatientGender + ",'" +
        //         patient.PatientPhoneNumber + "', '" +
        //         DateTime.Now + "' , 'No'" +
        //        ")";
        //    databaseProvider.runCommand(command);
        //}
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
        public void deleteDrug(int drugId)
        {
            string command = "UPDATE Drugs SET " +
                "[DeleteStatus] = 'Yes' WHERE ID=" + drugId;

            databaseProvider.runCommand(command);
        }

        public void restoreDrug(int drugId)
        {
            string command = "UPDATE Drugs SET " +
                "[DeleteStatus] = 'No' WHERE ID=" + drugId;

            databaseProvider.runCommand(command);
        }
    }
}
