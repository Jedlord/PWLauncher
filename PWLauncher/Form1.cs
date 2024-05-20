using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon.CloudSearch_2011_02_01.Model.Internal.MarshallTransformations;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using PWLauncher.Code;

namespace PWLauncher
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void Form1_Load(object sender, EventArgs e)
        {
            //AllocConsole();
            Init();
            Accounts.LoadFromJson();
            LauncherData.LoadFromJson();
            bool setToLastIndex = false;
            foreach (Accounts.Account acc in Accounts.AccountList)
            {
                AccountList.AddItem(acc.Username);
                if(Accounts.GetCurrentAccount() != null && Accounts.GetCurrentAccount().Username == acc.Username)
                {
                    AccountList.SelectedIndex = Accounts.AccountList.IndexOf(acc);
                    setToLastIndex = true;
                }
            }
            if(AccountList.Items.Count > 0 && !setToLastIndex)
            {
                AccountList.SelectedIndex = 0;
            }

            useMods.Checked = LauncherData.data.UseMods;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LauncherData.SaveToJson();
        }

        internal static async Task Init()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Setting up AWS...");
            Console.ResetColor();
            await Task.Run(() =>
            {
                AWSRequests.Start();
                AWSRequests.ConnectCognito();
            });
        }

        private async void StartPW_Click(object sender, EventArgs e)
        {
            if(Accounts.GetCurrentAccount() is null || Accounts.GetCurrentAccount() is default(Accounts.Account))
            {
                StartGame();
                return;
            }
            else
            {
                Accounts.Account acc = Accounts.GetCurrentAccount();
                AWSRequests.LoginInfo login = await AWSRequests.LoginWithUsernameAndPassword(acc.Username, acc.Password);
                Console.WriteLine(login.GetLoginInfo());
                if(login == null)
                {
                    StartGame();
                    return;
                }
                RegistryKey pw = Registry.CurrentUser.OpenSubKey("Software\\Kukouri\\Pixel Worlds", true);
                pw.SetValue("CognitoIdentity:IdentityId:us-east-1:b9d5be2b-8fae-4bc6-8a4b-e35fab411d76_h774736173", Encoding.ASCII.GetBytes(login.identityId), RegistryValueKind.Binary);
                pw.SetValue("lastLoginKey_h2295063355", Encoding.ASCII.GetBytes(login.logintoken), RegistryValueKind.Binary);
                StartGame();
                return;
            }
        }

        private void StartGame()
        {
            if(LauncherData.data.UseMods)
            {
                IniFile ini = new IniFile(LauncherData.doorstopIniPath);
                ini.Write("enabled", "true", "General");
            }
            else
            {
                IniFile ini = new IniFile(LauncherData.doorstopIniPath);
                ini.Write("enabled", "false", "General");
            }
            Process.Start(LauncherData.gameUri);
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            bool isFirstAddition = AccountList.Items.Count > 0 ? false : true;
            string user = UserInput.Text;
            string pass = PassInput.Text;
            if(Accounts.ContainsAccount(user))
            {
                AccountList.RemoveItem(AccountList.Items.Where(x => x.Text == user).FirstOrDefault());
                Accounts.UpdatePassword(user, pass);
                Console.WriteLine($"Updated password for {user}");
            }
            else
            {
                Accounts.AddAccount(user, pass);
            }
            AccountList.AddItem(user);
            if(isFirstAddition)
            {
                AccountList.SelectedIndex = 0;
                Accounts.SetCurrentAccount(user);
            }
        }

        private void RemoveAccount_Click(object sender, EventArgs e)
        {
            try
            {
                int index = AccountList.SelectedIndex;
                string user = AccountList.SelectedItem.Text;
                AccountList.RemoveItem(AccountList.SelectedItem);
                Accounts.RemoveAccount(user);

                try
                {
                    AccountList.SelectedIndex = index - 1;
                }
                catch { }
            }
            catch { }
        }

        private void AccountList_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            Accounts.SetCurrentAccount(selectedItem.Text);
        }

        private void useMods_CheckedChanged(object sender, EventArgs e)
        {
            LauncherData.data.UseMods = useMods.Checked;
            LauncherData.SaveToJson();
        }

        private void ForceClearData_Click(object sender, EventArgs e)
        {
            RegistryKey pw = Registry.CurrentUser.OpenSubKey("Software\\Kukouri\\Pixel Worlds", true);
            pw.DeleteValue("ListOfUsedUsernames_h1652973228");
            pw.DeleteValue("lastPlayerID_h2764011313");
            pw.DeleteValue("lastPlayerXPLevel_h2467737026");
            Console.WriteLine("Force cleared tracking data");

        }
    }
}
