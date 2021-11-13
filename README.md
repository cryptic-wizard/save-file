# settings-text-file

## Description
* Used to simplify reading and writing arbitrary data types to settings files
* Removes the need to explicitly convert non-string variables to string when writing a settings file
* Removes the need to explicitly parse non-string variables when reading a settings file
* [Strong typing](https://en.wikipedia.org/wiki/Strong_and_weak_typing) is preserved when reading a settings file

## Tests

## Usage
### Install Package:
### Include Package:

### Write Settings File
```C#
SettingsTextFile settingsTextFile = new SettingsTextFile();

settingsTextFile.Add("UserWorkstation", "DESKTOP-123");
settingsTextFile.Add("UserLastLogin", DateTime.Now);
settingsTextFile.Add("UserTotalLogins", 7);
settingsTextFile.Add("UserHours", 11.3);

settingsTextFile.Write("mySettings.txt");
```
```Text
UserWorkstation=String=DESKTOP-123
UserLastLogin=DateTime=11/12/2021 8:09:19 PM
UserTotalLogins=Int=7
UserHours=Double=11.3
```

### Read Settings File
```C#
SettingsTextFile readFile = SettingsTextFile.Read("mySettings.txt");

string userWorkstation = readFile.Strings["UserWorkstation"];
DateTime userLastLogin = readFile.DateTimes["UserLastLogin"];
int userTotalLogins = readFile.Ints["UserTotalLogins"];
double userHours = readFile.Doubles["UserHours"];
```
```Text
DESKTOP-123
11/12/2021 8:09:19 PM
7
11.3
```

## Features
### Recently Added
### Planned Features

## Tools
* [Visual Studio](https://visualstudio.microsoft.com/vs/)
* [NUnit 3](https://nunit.org/)
* [SpecFlow](https://specflow.org/tools/specflow/)
* [SpecFlow+ LivingDoc](https://specflow.org/tools/living-doc/)
* [Run SpecFlow Tests](https://github.com/marketplace/actions/run-specflow-tests)
## License
* [MIT License](https://github.com/cryptic-wizard/settings-file/blob/main/LICENSE.md)
