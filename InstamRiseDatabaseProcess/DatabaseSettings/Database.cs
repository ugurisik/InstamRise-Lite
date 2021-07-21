using Microsoft.Data.Sqlite;
namespace InstamRiseDatabaseProcess.DatabaseSettings
{
    public class Database
    {
        public static SqliteConnection GetConnection() {
            return new SqliteConnection(Models.DatabaseConnString.ConnectionString);
        }
    }
}
