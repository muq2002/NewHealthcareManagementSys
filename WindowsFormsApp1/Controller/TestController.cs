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
    class TestController
    {
        DatabaseProvider databaseProvider = new DatabaseProvider();
        public string DeleteStatus = "No";
        public DataTable readTests()
        {
            return databaseProvider.getTable("SELECT * FROM Tests" +
                " WHERE [DeleteStatus]='" + DeleteStatus + "' ORDER BY PatientID ASC");
        }
        public DataTable readTests(int limit = 100)
        {
            return databaseProvider.getTable("SELECT TOP " + limit + " * FROM Tests" +
                " WHERE [DeleteStatus]='" + DeleteStatus + "' ORDER BY PatientID ASC");
        }

        public DataTable readTestsByPatientID(int patientId)
        {
            return databaseProvider.getTable("SELECT t.ID, t.PatientID, t.TestID, myt.TestName ,t.TestValue, t.Comment, t.RegisterDate" +
            " FROM Tests AS t, MyTests AS myt" +
            " WHERE(t.TestID = myt.TestID AND t.PatientID = " + patientId +
            " AND [DeleteStatus]='" + DeleteStatus + "')");
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
            string command = "INSERT INTO Tests(" +
                "PatientID," +
                "TestID," +
                "TestValue," +
                "Comment," +
                "RegisterDate," +
                "DeleteStatus" +
                ") " +
                "VALUES(" +
                 test.PatientID + ", " +
                 test.TestID + ", '" +
                 test.TestValue + "', '" +
                 test.Comment + "', '" +
                 DateTime.Now + "' , 'No'" +
                ")";
            databaseProvider.runCommand(command);
        }
        public void updateTest(TestModel test)
        {
            string command = "UPDATE Tests SET " +
            "[TestValue] = '" + test.TestValue + "', " +
            "[Comment] = '" + test.Comment + "' " +
           " WHERE ID=" + test.ID;

            databaseProvider.runCommand(command);
        }
        public void deleteTest(int regTestId)
        {
            string command = "UPDATE Tests SET " +
                "[DeleteStatus] = 'Yes' WHERE ID=" + regTestId;

            databaseProvider.runCommand(command);
        }

        public void restoreTest(int regTestId)
        {
            string command = "UPDATE Tests SET " +
                "[DeleteStatus] = 'No' WHERE ID =" + regTestId;

            databaseProvider.runCommand(command);
        }
    }
}
