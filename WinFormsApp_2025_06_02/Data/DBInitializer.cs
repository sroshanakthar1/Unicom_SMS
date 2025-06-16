using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_2025_06_02.Data
{
    public static class DBInitializer
    {
        public static readonly string ConnectionString = "Data Source=SMS.db;Version=3;";

        public static void InitializeDatabase()
        {
            try
            {
                using var conn = new SQLiteConnection(ConnectionString);
                conn.Open();

                using var cmd = new SQLiteCommand(Migration.CreateUsersTable, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database initialization failed: {ex.Message}");
            }
        }
    }
}
