# save-file

## Description
* A text file read/write class for arbitrary data types .NET and .NET Core
* Removes the need to explicitly convert non-string variables to string when writing a text file
* Removes the need to explicitly parse non-string variables when reading a text file
* [Strong typing](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types) is preserved when reading a text save file

## Tests
[![.NET 5.0](https://github.com/cryptic-wizard/save-file/actions/workflows/dotnet.yml/badge.svg)](https://github.com/cryptic-wizard/save-file/actions/workflows/dotnet.yml)

[![.NET Core 3.1](https://github.com/cryptic-wizard/save-file/actions/workflows/dotnetcore.yml/badge.svg)](https://github.com/cryptic-wizard/save-file/actions/workflows/dotnetcore.yml)

## Usage
### Install Package
```Text
dotnet add package CrypticWizard.SaveFile
```
```xml
<PackageReference Include="CrypticWizard.SaveFile" Version="0.2.0"/>
```
### Include Package
```C#
using CrypticWizard.SaveFile;
```

### Write Settings File
```C#
TextSaveFile textSaveFile = new TextSaveFile();

textSaveFile.Add("Workstation", "DESKTOP-123");
textSaveFile.Add("LastLogin", DateTime.Now);
textSaveFile.Add("TotalLogins", 7);
textSaveFile.Add("Hours", 11.3);

textSaveFile.Write("mySettings.txt");
```
```Text
Workstation=string=DESKTOP-123
LastLogin=datetime=11/12/2021 8:09:19 PM
TotalLogins=int=7
Hours=double=11.3
```

### Read Settings File
```C#
TextSaveFile readFile = TextSaveFile.Read("mySettings.txt");

string userWorkstation = readFile.GetString("UserWorkstation");
DateTime? userLastLogin = readFile.GetDateTime("UserLastLogin");
int? userTotalLogins = readFile.GetInt("UserTotalLogins");
double? userHours = readFile.GetDouble("UserHours");
```
```Text
DESKTOP-123
11/12/2021 8:09:19 PM
7
11.3
```

## Features
### Supported Primitives
* string
* char
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
### Supported Classes
* DateTime
### Planned Features
* delimiter collision checking

## Tools
* [Visual Studio](https://visualstudio.microsoft.com/vs/)
* [NUnit 3](https://nunit.org/)
* [SpecFlow](https://specflow.org/tools/specflow/)
* [SpecFlow+ LivingDoc](https://specflow.org/tools/living-doc/)
* [Run SpecFlow Tests](https://github.com/marketplace/actions/run-specflow-tests)
## License
* [MIT License](https://github.com/cryptic-wizard/save-file/blob/main/LICENSE.md)
