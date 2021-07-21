using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstamRiseDatabaseProcess.DatabaseProcess
{
    public class Delete
    {
        SqliteConnection con = DatabaseSettings.Database.GetConnection();
        public bool DeleteData(int ID)
        {
            try
            {
                string query = "DELETE FROM ShareMedia where ID=" + ID;
                SqliteCommand cmd = new SqliteCommand(query, con);
                ConnOpen();
                cmd.ExecuteNonQuery();
                ConnClose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
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
