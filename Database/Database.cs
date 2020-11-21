using BGW.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BGW.Database
{
    public class Database
    {
        private static string connectionString = "";
        public static void OnResourceStart()
        {
            string host = "127.0.0.1";
            string user = "";
            string pass = "";
            string db = "";
            connectionString = "SERVER=" + host + "; DATABASE=" + db + "; UID=" + user + "; PASSWORD=" + pass + "; SSLMODE=none;";

            /* Load Account List */
            Account.Init.AccountList = LoadAccountList();
            /* Load Ban List */
            Admin.Init.AccountBans = LoadAccountBans();
        }

        public static List<AccountModel> LoadAccountList()
        {
            List<AccountModel> AccountModel = new List<AccountModel>();
            using MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Accounts";
            using MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                AccountModel accClass = new AccountModel
                {
                    UID = reader.GetInt32("UID"),
                    Username = reader.GetString("Username"),
                    HardwareIdHash = reader.GetString("HardwareId"),
                    SocialClubId = reader.GetString("SocialId"),
                };
                AccountModel.Add(accClass);
            }
            return AccountModel;
        }
        public static List<BanModel> LoadAccountBans()
        {
            List<BanModel> AccountBans = new List<BanModel>();
            using MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Bans";
            using MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                BanModel accClass = new BanModel
                {
                    UID = reader.GetInt32("UID"),
                    SCID = reader.GetString("SCID"),
                    HardwareId = reader.GetString("HardwareId"),
                    Reason = reader.GetString("Reason"),
                };
                AccountBans.Add(accClass);
            }
            return AccountBans;
        }
        public static void RegisterAccount(string Username, string SpielerSocial, string HardwareIdHash)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO player (Username, SocialClubId, HardwareIdHash) VALUES(@Username, @SpielerSocial, @HardwareIdHash)";
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@SpielerSocial", SpielerSocial);
                command.Parameters.AddWithValue("@HardwareIdHash", HardwareIdHash);
                command.ExecuteNonQuery();
            }
            catch (Exception ex) { Core.Debug.CatchException(ex); }
        }
        public static void CreateNewBanEntry(BanModel banClass)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO bans (UID, SCID, HardwareId, Reason) VALUES(@UID, @SCID, @HardwareId, @Reason)";
                command.Parameters.AddWithValue("@UID", banClass.UID);
                command.Parameters.AddWithValue("@SCID", banClass.SCID);
                command.Parameters.AddWithValue("@HardwareId", banClass.HardwareId);
                command.Parameters.AddWithValue("@Reason", banClass.Reason);
                command.ExecuteNonQuery();
            }
            catch (Exception ex) { Core.Debug.CatchException(ex); }
        }
    }
}
