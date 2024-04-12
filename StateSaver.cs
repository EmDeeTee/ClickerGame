using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace ClickerGame
{
    public static class StateSaver {
        public static SQLiteConnection ConnectOrCreate() {
            if (!File.Exists("ClickerDB.db"))
                File.Create("ClickerDB.db");
            SQLiteConnection DB;
            DB = new SQLiteConnection("Data Source=ClickerDB.db; Version = 3; New = True; Compress = True; ");
            return DB;
        }

        public static void EraseDatabase() {
            using (SQLiteConnection DB = ConnectOrCreate()) {
                DB.Open();
                using (SQLiteTransaction transaction = DB.BeginTransaction())
                {
                    SQLiteCommand sqlite_cmd = DB.CreateCommand();
                    sqlite_cmd.CommandText = "DELETE FROM CompletedAchievements;";
                    sqlite_cmd.ExecuteNonQuery();

                    sqlite_cmd.CommandText = "DELETE FROM Points;";
                    sqlite_cmd.ExecuteNonQuery();

                    transaction.Commit();
                }
            }
        }

        public static void SaveState() {
            // TODO: Not everything is saved. And this game should probably not use an SQL DB to store it.
            using (SQLiteConnection DB = ConnectOrCreate())
            {
                DB.Open();
                using (SQLiteTransaction transaction = DB.BeginTransaction())
                {
                    SQLiteCommand sqlite_cmd = DB.CreateCommand();
                    sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS Points (Count INT)";
                    sqlite_cmd.ExecuteNonQuery();

                    sqlite_cmd.CommandText = "DELETE FROM Points;";
                    sqlite_cmd.ExecuteNonQuery();

                    sqlite_cmd.CommandText = $"INSERT INTO Points (Count) VALUES ({Game.Points})";
                    sqlite_cmd.ExecuteNonQuery();

                    transaction.Commit();
                }
            }
        }

        public static int ReadState() {
            using (SQLiteConnection DB = ConnectOrCreate()) {
                DB.Open();
                SQLiteCommand sqlite_cmd = DB.CreateCommand();
                sqlite_cmd.CommandText = "SELECT Count FROM Points";

                int res = 0;
                try  {
                    object result = sqlite_cmd.ExecuteScalar();
                    if (result != null) {
                        res = Convert.ToInt32(result);
                    }
                }
                catch (Exception) {
                    return 0;
                }

                return res;
            }
        }

        public static void CreateDBTableWithValues(string tableName, string[] values) {
            using (SQLiteConnection DB = ConnectOrCreate()) {
                DB.Open();
                using (SQLiteTransaction transaction = DB.BeginTransaction()) {
                    SQLiteCommand sqlite_cmd = DB.CreateCommand();
                    sqlite_cmd.CommandText = $"CREATE TABLE IF NOT EXISTS {tableName} (AUTO string)";
                    sqlite_cmd.ExecuteNonQuery();

                    foreach (string val in values) {
                        sqlite_cmd.CommandText = $"INSERT INTO {tableName} (AUTO) VALUES ('{val}')";
                        sqlite_cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
        }

        public static string[] ReadDBTableWithValues(string tableName)
        {
            List<string> result = new List<string>();

            using (SQLiteConnection DB = ConnectOrCreate())
            {
                DB.Open();
                using (SQLiteTransaction transaction = DB.BeginTransaction())
                {
                    SQLiteCommand sqlite_cmd = DB.CreateCommand();
                    sqlite_cmd.CommandText = $"SELECT AUTO FROM {tableName}";

                    using (SQLiteDataReader reader = sqlite_cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string val = reader["AUTO"].ToString();
                            result.Add(val);
                        }
                    }

                    transaction.Commit();
                }
            }

            return result.ToArray();
        }
    }
}
