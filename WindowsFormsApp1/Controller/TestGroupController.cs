using HealthcareManagement.Model;
using HealthcareManagement.Screens.Config;
using System.Data;


namespace HealthcareManagement.Controller
{
    class TestGroupController
    {
        DatabaseProvider databaseProvider = new DatabaseProvider();
        public string DeleteStatus = "No";


        public TestGroupController() { }
        public DataTable getGroupNames()
        {
            return databaseProvider.getTable("SELECT * FROM TestGroups" +
                " WHERE [DeleteStatus]='" + DeleteStatus + "' ORDER BY ID ASC");
        }
        public DataTable getSubGroupNames(int groupId)
        {
            return databaseProvider.getTable("SELECT ConnectionGroup.SubGroupID, Count(*) AS Expr1" +
                " FROM ConnectionGroup " +
                " WHERE(((ConnectionGroup.[GroupID]) = " + groupId .ToString() + "))" +
                " GROUP BY ConnectionGroup.SubGroupID; ");
        }
        public DataTable getSingleSubGroupNames(int subGroupId)
        {
            return databaseProvider.getTable("SELECT * FROM SubGroupTests" +
                " WHERE ([ID] = " + subGroupId  + " AND [DeleteStatus]='" + DeleteStatus + "')" +
                " ORDER BY ID ASC");
        }

        public DataTable getSingleSubGroupNames(string subGroupName)
        {
            return databaseProvider.getTable("SELECT * FROM SubGroupTests" +
                " WHERE ([SubGroupName] = '" + subGroupName + "' AND [DeleteStatus]='" + DeleteStatus + "')" +
                " ORDER BY ID ASC");
        }

        public DataTable getSingleTestGroups(int groupId)
        {
            return databaseProvider.getTable("SELECT * FROM TestGroups" +
                " WHERE ([ID] = " + groupId + " AND [DeleteStatus]='" + DeleteStatus + "') " +
                "ORDER BY ID ASC");
        }


        public void createSubGroup(string subGroupName)
        {
            string command = "INSERT INTO SubGroupTests(" +
                "SubGroupName," +
                "DeleteStatus" +
                ") " +
                "VALUES('" +
                 subGroupName + "', " +
                 "'No'" +
                ")";
            databaseProvider.runCommand(command);
        }

        public void addTestsToCustomSubGroup(int subGroupId, int testId)
        {
            string command = "INSERT INTO ConnectionGroup(" +
                "GroupID," +
                "SubGroupID," +
                "TestID" +
                ") " +
                "VALUES(7," +
                  subGroupId + ", " +
                 testId +
                ")";
            databaseProvider.runCommand(command);
        }
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
