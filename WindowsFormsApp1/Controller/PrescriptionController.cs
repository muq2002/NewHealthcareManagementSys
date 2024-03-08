using HealthcareManagement.Model;
using HealthcareManagementSystem.Config;
using System;
using System.Data;

namespace HealthcareManagement.Controller
{
    class PrescriptionController
    {
        DatabaseProvider databaseProvider = new DatabaseProvider();
        public string DeleteStatus = "No";


        public PrescriptionController() { }
        public DataTable readPrescriptions()
        {
            return databaseProvider.getTable("SELECT * FROM Prescriptions" +
                " WHERE [DeleteStatus]='" + DeleteStatus + "' ORDER BY ID ASC");
        }


        public DataTable getPrescriptionByPatientId(int patientId)
        {
            return databaseProvider.getTable("SELECT pre.ID, pre.SessionID, pre.DrugID," +
                " sess.SessionName,drg.DrugName, pre.Instruction, sess.RegisterDate" +
                " FROM (Prescriptions AS pre" +
                " INNER JOIN Drugs AS drg ON pre.DrugID = drg.ID)" +
                " INNER JOIN Sessions AS sess ON pre.SessionID = sess.ID" +
                " WHERE (pre.PatientID = " + patientId + " AND pre.DeleteStatus = '" + DeleteStatus + "')");
        }

        public DataTable getPrescriptionBySessionId(int sessionId)
        {
            return databaseProvider.getTable("SELECT * FROM Prescriptions" +
                " WHERE ([SessionID] = " + sessionId + " AND [DeleteStatus]='" + DeleteStatus + "') " +
                "ORDER BY ID ASC");
        }
        public void createPrescription(PrescriptionModel prescription)
        {
            string command = "INSERT INTO Prescriptions(" +
                "PatientID," +
                "SessionID," +
                "DrugID," +
                "Instruction," +
                "DeleteStatus" +
                ") " +
                "VALUES(" +
                 prescription.PatientID + ", " +
                 prescription.SessionID + ", " +
                 prescription.DrugID + ", '" +
                 prescription.Instruction + "', 'No'" +
                ")";
            databaseProvider.runCommand(command);
        }
        //public void updatePatient(PrescriptionModel prescription)
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
        public void deletePrescrioption(int prescriptionId)
        {
            string command = "UPDATE Prescriptions SET " +
                "[DeleteStatus] = 'Yes' WHERE ID=" + prescriptionId;

            databaseProvider.runCommand(command);
        }

        public void restorePatient(int prescriptionId)
        {
            string command = "UPDATE Prescriptions SET " +
                "[DeleteStatus] = 'No' WHERE ID=" + prescriptionId;

            databaseProvider.runCommand(command);
        }
    }
}
