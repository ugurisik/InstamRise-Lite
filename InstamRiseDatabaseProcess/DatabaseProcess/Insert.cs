using InstamRiseDataProcess.Models;
using Microsoft.Data.Sqlite;

namespace InstamRiseDatabaseProcess.DatabaseProcess
{
    public class Insert
    {
        SqliteConnection con = DatabaseSettings.Database.GetConnection();
        public bool InsertData() {
            try
            {
                string query = "INSERT INTO ShareMedia(ShareAccount,ShareDate,ShareTime,ShareImagePath,Status) VALUES (@acc,@date,@time,@path,@status)";
                SqliteCommand cmd = new SqliteCommand(query, con);
                cmd.Parameters.AddWithValue("@acc", Models.ShareModels.ShareAccount);
                cmd.Parameters.AddWithValue("@date", Models.ShareModels.ShareDate);
                cmd.Parameters.AddWithValue("@time", Models.ShareModels.ShareTime);
                cmd.Parameters.AddWithValue("@path", Models.ShareModels.ShareImagePath);
                cmd.Parameters.AddWithValue("@status", Models.ShareModels.Status);
                ConnOpen();
                cmd.ExecuteNonQuery();
                ConnClose();
                return true;
            }
            catch (System.Exception ex )
            {
                ExceptionStatus.Exception = ex.Message;
                return false;
            }
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
