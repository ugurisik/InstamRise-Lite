using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstamRiseDatabaseProcess.DatabaseProcess
{
    public class GetDatabaseData
    {
        SqliteConnection con = DatabaseSettings.Database.GetConnection();
        public DataTable GetDataTable() {
            DataTable dataTable = new DataTable();
            ConnOpen();
            string query = "SELECT ID,ShareAccount as Hesap_Adı,ShareDate || ' ' || ShareTime as Paylaşım_Tarihi,ShareImagePath as Görsel_Yolu from ShareMedia where status=0 ORDER BY ShareDate ASC";
            SqliteCommand cmd = new SqliteCommand(query, con);
            SqliteDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataTable = dt;
            }
            dr.Close();
            ConnClose();
            return dataTable;
        }
        public void ConnOpen()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {

                SQLitePCL.Batteries.Init();
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
