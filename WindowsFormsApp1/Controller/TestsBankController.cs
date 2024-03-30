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
    class TestsBankController
    {
        DatabaseProvider databaseProvider = new DatabaseProvider();
        public string DeleteStatus = "No";


        public TestsBankController() { }
        public DataTable readTestsBank()
        {
            return databaseProvider.getTable("SELECT * FROM TestsBank" +
                " WHERE [DeleteStatus]='" + DeleteStatus + "' ORDER BY ID ASC");
        }


        public DataTable getSingleTestsByGroups(int groupId)
        {
            return databaseProvider.getTable("SELECT cg.GroupID, cg.SubGroupID, cg.TestID," +
                " tb.ID, tb.TestName, tb.ReferenceRange, tb.DeleteStatus" +
                " FROM ConnectionGroup AS cg" +
                " INNER JOIN TestsBank AS tb ON cg.TestID = tb.ID" +
                " WHERE (cg.GroupID = " + groupId.ToString() +
                " AND tb.DeleteStatus='" + DeleteStatus + "')" +
                " ORDER BY tb.ID ASC");
        }
        public DataTable getSingleTestsBySubGroups(int subGroupId)
        {
            return databaseProvider.getTable("SELECT cg.GroupID, cg.SubGroupID, cg.TestID," +
                " tb.ID, tb.TestName, tb.ReferenceRange, tb.DeleteStatus" +
                " FROM ConnectionGroup AS cg" +
                " INNER JOIN TestsBank AS tb ON cg.TestID = tb.ID" +
                " WHERE (cg.SubGroupID = " + subGroupId.ToString() +
                " AND tb.DeleteStatus='" + DeleteStatus + "')" +
                " ORDER BY tb.ID ASC");
        }

        public void createPatient(TestsBankModel testsBankModel)
        {
            string command = "INSERT INTO TestGroups(" +
                "TestName," +
                "GroupRelated," +
                "DeleteStatus" +
                ") " +
                "VALUES('" +
                 testsBankModel.TestName + "', '" +
                 testsBankModel.GroupRelated + "', " +
                 "'No'" +
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
        public void deleteTestsBank(int testId)
        {
            string command = "UPDATE TestsBank SET " +
                "[DeleteStatus] = 'Yes' WHERE ID=" + testId;

            databaseProvider.runCommand(command);
        }

        public void restoreTestsBank(int testId)
        {
            string command = "UPDATE TestsBank SET " +
                "[DeleteStatus] = 'No' WHERE ID=" + testId;

            databaseProvider.runCommand(command);
        }
    }
}
