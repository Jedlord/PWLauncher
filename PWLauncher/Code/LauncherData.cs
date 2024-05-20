using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PWLauncher.Code
{
    internal class LauncherData
    {
        public class JsonData
        {
            public JsonData()
            {
                CurrentAccount = null;
                UseMods = false;
            }
            public Accounts.Account CurrentAccount { get; set; }
            public bool UseMods { get; set; }
        }

        public static JsonData data = new JsonData();

        public static readonly string gameUri = "steam://rungameid/636040";
        public static readonly string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PWLauncher";
        public static readonly string accountListPath = FileAt(appDataPath, "accountlist.json");
        //public static readonly string currentAccountPath = FileAt(appDataPath, "currentAccount.json");
        public static readonly string launcherDataPath = FileAt(appDataPath, "launcherdata.json");
        public static readonly string pwPath = GetPWPath();
        public static readonly string doorstopIniPath = FileAt(pwPath, "doorstop_config.ini");

        private static string FileAt(string directory, string fileName) => string.Join("\\", new string[] { directory, fileName });

        private static string GetPWPath()
        {
            RegistryKey steam = Registry.LocalMachine.OpenSubKey("Software\\WOW6432Node\\Valve\\Steam");
            string steamPath = (string)steam.GetValue("InstallPath");
            string pwPath = steamPath + "\\steamapps\\common\\Pixel Worlds";
            return pwPath;
        }

        public static void SaveToJson()
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);

            File.WriteAllText(launcherDataPath, json);
        }

        public static void LoadFromJson()
        {
            if (File.Exists(launcherDataPath))
            {
                string json = File.ReadAllText(launcherDataPath);
                if (!String.IsNullOrWhiteSpace(json))
                {
                    data = JsonConvert.DeserializeObject<JsonData>(json);
                }
            }

            else
            {
                if (!Directory.Exists(appDataPath))
                {
                    Directory.CreateDirectory(appDataPath);
                }
                File.WriteAllText(launcherDataPath, string.Empty);
                data = new JsonData();
            }
        }
    }
}
