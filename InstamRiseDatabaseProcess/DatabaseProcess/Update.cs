using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstamRiseDatabaseProcess.DatabaseProcess
{
    public class Update
    {
        SqliteConnection con = DatabaseSettings.Database.GetConnection();
        public void UpdateData(int ID) {
            try
            {
                string query = "UPDATE ShareMedia SET Status=:Status WHERE ID=:ID";
                SqliteCommand cmd = new SqliteCommand(query, con);
                cmd.Parameters.AddWithValue("Status", 1);
                cmd.Parameters.AddWithValue("ID", ID);
                ConnOpen();
                cmd.ExecuteNonQuery();
                ConnClose();
            }
            catch (Exception)
            {

            }
        }
        public void ConnOpen()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void ConnClose()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
