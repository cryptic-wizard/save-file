# settings-text-file

## Description
* Used to simplify reading and writing arbitrary data types to settings files
* Removes the need to explicitly convert non-string variables to string when writing a settings file
* Removes the need to explicitly parse non-string variables when reading a settings file
* [Strong typing](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types) is preserved when reading a settings file

## Tests
[![.NET 5.0](https://github.com/cryptic-wizard/settings-text-file/actions/workflows/dotnet.yml/badge.svg)](https://github.com/cryptic-wizard/settings-text-file/actions/workflows/dotnet.yml)

[![.NET Core 3.1](https://github.com/cryptic-wizard/settings-text-file/actions/workflows/dotnetcore.yml/badge.svg)](https://github.com/cryptic-wizard/settings-text-file/actions/workflows/dotnetcore.yml)

## Usage
### Install Package
```Text
dotnet add package CrypticWizard.TODO
```
```xml
<PackageReference Include="CrypticWizard.TODO" Version="0.1.0"/>
```
### Include Package
```C#
using CrypticWizard.TODO;
```

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
UserWorkstation=string=DESKTOP-123
UserLastLogin=datetime=11/12/2021 8:09:19 PM
UserTotalLogins=int=7
UserHours=double=11.3
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
### Supported Data Types
* string
* char
* DateTime
* bool
* sbyte
* short
* int
* long
* byte
* ushort
* uint
* ulong
* double
* float
* decimal
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
