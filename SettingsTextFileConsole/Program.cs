using SettingsFile;
using System;

namespace SettingsFileConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SettingsTextFile settingsTextFile = new SettingsTextFile();

            settingsTextFile.Add("UserWorkstation", "DESKTOP-123");
            settingsTextFile.Add("UserLastLogin", DateTime.Now);
            settingsTextFile.Add("UserTotalLogins", 7);
            settingsTextFile.Add("UserHours", 11.3);

            settingsTextFile.Write("settings.txt");

            SettingsTextFile readFile = SettingsTextFile.Read("settings.txt");

            string userWorkstation = readFile.Strings["UserWorkstation"];
            DateTime userLastLogin = readFile.DateTimes["UserLastLogin"];
            int userTotalLogins = readFile.Ints["UserTotalLogins"];
            double userHours = readFile.Doubles["UserHours"];

        }
    }
}
