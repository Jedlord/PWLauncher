using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace PWLauncher.Code
{
    internal static class Accounts
    {
        private static readonly string accountListPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\PWLauncher\accountlist.json";
        public class Account
        {
            public Account(string user, string pass)
            {
                Username = user;
                Password = pass;
            }

            public string Username { get; set; }
            public string Password { get; set; }
        }

        public static List<Account> AccountList { get; private set; }

        public static void AddAccount(string user, string pass)
        {
            AccountList.Add(new Account(user, pass));
            SaveToJson();
        }

        public static void RemoveAccount(string user)
        {
            AccountList.Remove(AccountList.Where(x => x.Username == user).FirstOrDefault());
            SaveToJson();
        }

        public static void RemoveAccount(Account acc)
        {
            AccountList.Remove(acc);
            SaveToJson();
        }

        public static bool ContainsAccount(string user)
        {
            Account acc = AccountList.Where(x => x.Username == user).FirstOrDefault();
            if(acc == default(Account))
            {
                return false;
            }
            return true;
        }

        public static Account GetCurrentAccount()
        {
            return LauncherData.data.CurrentAccount;
        }

        public static void SetCurrentAccount(string user)
        {
            LauncherData.data.CurrentAccount = GetAccount(user);
            LauncherData.SaveToJson();
        }

        public static Account GetAccount(string user)
        {
            return AccountList.Where(x => x.Username == user).FirstOrDefault();
        }

        public static void UpdatePassword(string user, string pass)
        {
            AccountList.First(x => x.Username == user).Password = pass;
            SaveToJson();
        }

        private static void SaveToJson()
        {
            string json = JsonConvert.SerializeObject(AccountList, Formatting.Indented);

            File.WriteAllText(accountListPath, json);
        }

        public static void LoadFromJson()
        {
            if(File.Exists(accountListPath))
            {
                string json = File.ReadAllText(accountListPath);
                if(!String.IsNullOrWhiteSpace(json))
                {
                    AccountList = JsonConvert.DeserializeObject<List<Account>>(json);
                }
            }

            else
            {
                if(!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\PWLauncher"))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\PWLauncher");
                }
                File.WriteAllText(accountListPath, string.Empty);
                AccountList = new List<Account>();
            }
        }
    }
}