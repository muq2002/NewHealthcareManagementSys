using System;
using System.Data;
using HealthcareManagement.Screens.Config;
using HealthcareManagement.Screens.Model;

namespace HealthcareManagement.Screens.Controller
{
    class TestController
    {
        DatabaseProvider databaseProvider = new DatabaseProvider();
        public string DeleteStatus = "No";
        public DataTable readTests()
        {
            return databaseProvider.getTable("SELECT * FROM Lab" +
                " WHERE [DeleteStatus]='" + DeleteStatus + "' ORDER BY PatientID ASC");
        }
        public DataTable readTests(int limit)
        {
            return databaseProvider.getTable("SELECT t.ID, t.PatientID, p.PatientName," +
                " t.TestID, myt.TestName, t.TestValue, t.Comments, t.RegisterDate" +
                " FROM (Lab AS t" +
                " INNER JOIN Patients AS p ON t.PatientID = p.ID)" +
                " INNER JOIN TestsBank AS myt ON t.TestID = myt.ID" +
                " WHERE t.DeleteStatus = '" + DeleteStatus + "'");
        }
        public DataTable saerchPatientsTests(int limit, string patientName)
        {
            return databaseProvider.getTable("SELECT t.ID, t.PatientID, p.PatientName," +
                " t.TestID, myt.TestName, t.TestValue, t.Comments, t.RegisterDate" +
                " FROM (Lab AS t" +
                " INNER JOIN Patients AS p ON t.PatientID = p.ID)" +
                " INNER JOIN TestsBank AS myt ON t.TestID = myt.ID" +
                " WHERE (p.PatientName LIKE '" + patientName + "%'" +
                " AND t.DeleteStatus = '" + DeleteStatus + "')");
        }



        public DataTable readTestsByPatientID(int patientId)
        {
            return databaseProvider.getTable("SELECT t.ID, t.PatientID," +
            " t.TestID, myt.TestName ,t.TestValue, t.Comments, t.RegisterDate" +
            " FROM Lab AS t, TestsBank AS myt" +
            " WHERE(t.TestID = myt.ID AND t.PatientID = " + patientId +
            " AND [t.DeleteStatus]='" + DeleteStatus + "')");
        }

        public DataTable readTestsBySesssionID(int sessionId)
        {
            return databaseProvider.getTable("SELECT t.ID, t.PatientID," +
            " t.TestID, myt.TestName ,t.TestValue, t.Comments, t.RegisterDate" +
            " FROM Lab AS t, TestsBank AS myt" +
            " WHERE(t.TestID = myt.ID AND t.SessionID = " + sessionId +
            " AND [t.DeleteStatus]='" + DeleteStatus + "')");
        }


        public DataTable readMyTests()
        {
            return databaseProvider.getTable("SELECT * FROM MyTests ORDER BY TestID ASC");
        }

        public DataTable searchTests(string searchText)
        {
            return databaseProvider.getTable("SELECT * FROM Tests" +
                " WHERE (TestName LIKE '" + searchText + "%'" +
                "AND [DeleteStatus]='" + DeleteStatus + "' ORDER BY PatientID ASC");
        }
        public void createTest(TestModel test)
        {
            string command = "INSERT INTO Lab(" +
                "PatientID," +
                "SessionID," +
                "TestID," +
                "TestValue," +
                "Comments," +
                "RegisterDate," +
                "DeleteStatus" +
                ") " +
                "VALUES(" +
                 test.PatientID + ", " +
                 test.SessionID + ", " +
                 test.TestID + ", '" +
                 test.TestValue + "', '" +
                 test.Comment + "', '" +
                 DateTime.Now + "' , 'No'" +
                ")";
            databaseProvider.runCommand(command);
        }
        public void updateTest(TestModel test)
        {
            string command = "UPDATE Lab SET " +
            "[TestValue] = '" + test.TestValue + "', " +
            "[Comments] = '" + test.Comment + "' " +
           " WHERE (ID=" + test.ID + " AND PatientID=" + test.PatientID + ")";

            databaseProvider.runCommand(command);
        }
        public void deleteTest(int regTestId)
        {
            string command = "UPDATE Lab SET " +
                "[DeleteStatus] = 'Yes' WHERE ID=" + regTestId;

            databaseProvider.runCommand(command);
        }

        public void restoreTest(int regTestId)
        {
            string command = "UPDATE Lab SET " +
                "[DeleteStatus] = 'No' WHERE ID =" + regTestId;

            databaseProvider.runCommand(command);
        }
    }
}
