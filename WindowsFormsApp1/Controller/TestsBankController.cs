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


        public DataTable getSingleTestGroups(string relatedGroup)
        {
            return databaseProvider.getTable("SELECT * FROM TestsBank" +
                " WHERE ([GroupRelated] = '" + relatedGroup + "' AND [DeleteStatus]='" + DeleteStatus + "') " +
                "ORDER BY ID ASC");
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
