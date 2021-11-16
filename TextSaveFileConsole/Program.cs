using CrypticWizard.TextSaveFile;
using System;

namespace CrypticWizard.TextSaveFile
{
    class Program
    {
        static void Main(string[] args)
        {
            TextSaveFile textSaveFile = new TextSaveFile();

            textSaveFile.Add("UserWorkstation", "DESKTOP-123");
            textSaveFile.Add("UserLastLogin", DateTime.Now);
            textSaveFile.Add("UserTotalLogins", 7);
            textSaveFile.Add("UserHours", 11.3);

            textSaveFile.Write("settings.txt");

            TextSaveFile readFile = TextSaveFile.Read("settings.txt");

            string userWorkstation = readFile.Strings["UserWorkstation"];
            DateTime userLastLogin = readFile.DateTimes["UserLastLogin"];
            int userTotalLogins = readFile.Ints["UserTotalLogins"];
            double userHours = readFile.Doubles["UserHours"];
        }
    }
}
