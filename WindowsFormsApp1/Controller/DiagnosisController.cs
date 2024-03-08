using System;
using HealthcareManagement.Model;
using HealthcareManagementSystem.Config;
using System.Data;


namespace HealthcareManagement.Controller
{
    class DiagnosisController
    {
        DatabaseProvider databaseProvider = new DatabaseProvider();
        public string DeleteStatus = "No";


        public DiagnosisController() { }
        public DataTable readDiagnosis()
        {
            return databaseProvider.getTable("SELECT * FROM Diagnosis" +
                " WHERE [DeleteStatus]='" + DeleteStatus + "' ORDER BY ID ASC");
        }

        public DataTable getDiagnosisByPatientId(int patientId)
        {
            return databaseProvider.getTable("SELECT * FROM Diagnosis" +
                " WHERE [PatientID] = " + patientId +
                " ORDER BY ID ASC");
        }

        public DataTable getDiagnosisBySessionId(int sessionId)
        {
            return databaseProvider.getTable("SELECT * FROM Diagnosis" +
                " WHERE [SessionID] = " + sessionId + 
                " ORDER BY ID ASC");
        }

        public void saveDiagnosis(DiagnosisModel diagnosis)
        {
            if(getDiagnosisBySessionId(diagnosis.SessionID).Rows.Count == 0)
            {
                createDiagnosis(diagnosis);
            }
            else
            {
                updateDiagnosis(diagnosis);
            }
        }
        public void createDiagnosis(DiagnosisModel diagnosis)
        {
            string command = "INSERT INTO Diagnosis(" +
                "PatientID," +
                "SessionID," +
                "Comments," +
                "AutoDiagnosis," +
                "RegisterDate" +
                ") " +
                "VALUES(" +
                 diagnosis.PatientID + ", " +
                 diagnosis.SessionID + ", '" +
                 diagnosis.Comments + "', '" +
                 diagnosis.AutoDiagnosis + "','" + DateTime.Now +
                "')";
            databaseProvider.runCommand(command);
        }
        public void updateDiagnosis(DiagnosisModel diagnosis)
        {
            string command = "UPDATE Diagnosis SET " +
            "[Comments] = '" + diagnosis.Comments + "', " +
            "[AutoDiagnosis] = '" + diagnosis.AutoDiagnosis + "' " +
            "WHERE SessionID=" + diagnosis.SessionID;

            databaseProvider.runCommand(command);
        }
        public void deleteDiagnosis(int diagnosisId)
        {
            string command = "UPDATE Diagnosis SET " +
                "[DeleteStatus] = 'Yes' WHERE ID=" + diagnosisId;

            databaseProvider.runCommand(command);
        }

        public void restoreDiagnosis(int diagnosisId)
        {
            string command = "UPDATE Diagnosis SET " +
                "[DeleteStatus] = 'No' WHERE ID=" + diagnosisId;

            databaseProvider.runCommand(command);
        }
    }
}
