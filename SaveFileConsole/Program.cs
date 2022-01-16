using System;

namespace CrypticWizard.SaveFile
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

            string userWorkstation = readFile.GetString("UserWorkstation");
            DateTime? userLastLogin = readFile.GetDateTime("UserLastLogin");
            int? userTotalLogins = readFile.GetInt("UserTotalLogins");
            double? userHours = readFile.GetDouble("UserHours");
        }
    }
}
