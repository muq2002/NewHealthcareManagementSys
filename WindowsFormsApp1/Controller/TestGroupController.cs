using HealthcareManagement.Model;
using HealthcareManagementSystem.Config;
using System.Data;


namespace HealthcareManagement.Controller
{
    class TestGroupController
    {
        DatabaseProvider databaseProvider = new DatabaseProvider();
        public string DeleteStatus = "No";


        public TestGroupController() { }
        public DataTable readTestGroups()
        {
            return databaseProvider.getTable("SELECT * FROM TestGroups" +
                " WHERE [DeleteStatus]='" + DeleteStatus + "' ORDER BY ID ASC");
        }


        public DataTable getSingleTestGroups(int groupId)
        {
            return databaseProvider.getTable("SELECT * FROM TestGroups" +
                " WHERE ([ID] = " + groupId + " AND [DeleteStatus]='" + DeleteStatus + "') " +
                "ORDER BY ID ASC");
        }


        public void createPatient(TestGroupModel testGroupModel)
        {
            string command = "INSERT INTO TestGroups(" +
                "GroupName," +
                "DeleteStatus" +
                ") " +
                "VALUES('" +
                 testGroupModel.GroupName + "', " +
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
        public void deleteTestGroups(int groupId)
        {
            string command = "UPDATE TestGroups SET " +
                "[DeleteStatus] = 'Yes' WHERE ID=" + groupId;

            databaseProvider.runCommand(command);
        }

        public void restoreTestGroups(int groupId)
        {
            string command = "UPDATE TestGroups SET " +
                "[DeleteStatus] = 'No' WHERE ID=" + groupId;

            databaseProvider.runCommand(command);
        }
    }
}
