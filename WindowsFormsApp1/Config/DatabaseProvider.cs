using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1.Config
{
    class DatabaseProvider
    {
        static string constr = getDatabasePath();
        OleDbConnection dbcon = new OleDbConnection(constr);

        public static string getDatabasePath()
        {
            string appDataFolder = Application.StartupPath;
            appDataFolder = @"C:\Users\mktad\source\repos\NewHealthcareManagementSys\WindowsFormsApp1\bin\Debug";

            return "provider=microsoft.ace.oledb.12.0;" +
                        " data source=" + appDataFolder + @"\config\HealthcareManagementSystem.accdb;";

        }
        public void runCommand(string query)
        {
            try
            {
                OleDbCommand command = dbcon.CreateCommand();
                if (dbcon.State == ConnectionState.Closed)
                    dbcon.Open();


                command.Connection = dbcon;
                command.CommandText = query;

                command.ExecuteNonQuery();

                dbcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public DataTable getTable(string queryTable)
        {
            try
            {
                OleDbCommand command = dbcon.CreateCommand();
                if (dbcon.State == ConnectionState.Closed)
                    dbcon.Open();


                command.Connection = dbcon;
                command.CommandText = queryTable;

                DataTable holderTable = getHolderTable(command);

                return holderTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                Application.Exit();
                return new DataTable();
            }
        }

        private static DataTable getHolderTable(OleDbCommand command)
        {
            OleDbDataAdapter adapterData = new OleDbDataAdapter(command);
            DataTable holderTable = new DataTable();
            adapterData.Fill(holderTable);
            return holderTable;
        }
    }
}
