# text-save-file

## Description
* Used to simplify reading and writing arbitrary data types to text files
* Removes the need to explicitly convert non-string variables to string when writing a text file
* Removes the need to explicitly parse non-string variables when reading a text file
* [Strong typing](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types) is preserved when reading a text save file

## Tests
[![.NET 5.0](https://github.com/cryptic-wizard/text-save-file/actions/workflows/dotnet.yml/badge.svg)](https://github.com/cryptic-wizard/text-save-file/actions/workflows/dotnet.yml)

[![.NET Core 3.1](https://github.com/cryptic-wizard/text-save-file/actions/workflows/dotnetcore.yml/badge.svg)](https://github.com/cryptic-wizard/text-save-file/actions/workflows/dotnetcore.yml)

## Usage
### Install Package
```Text
dotnet add package CrypticWizard.TextSaveFile
```
```xml
<PackageReference Include="CrypticWizard.TextSaveFile" Version="0.1.0"/>
```
### Include Package
```C#
using CrypticWizard.TextSaveFile;
```

### Write Settings File
```C#
TextSaveFile textSaveFile = new TextSaveFile();

textSaveFile.Add("UserWorkstation", "DESKTOP-123");
textSaveFile.Add("UserLastLogin", DateTime.Now);
textSaveFile.Add("UserTotalLogins", 7);
textSaveFile.Add("UserHours", 11.3);

textSaveFile.Write("mySettings.txt");
```
```Text
UserWorkstation=string=DESKTOP-123
UserLastLogin=datetime=11/12/2021 8:09:19 PM
UserTotalLogins=int=7
UserHours=double=11.3
```

### Read Settings File
```C#
TextSaveFile readFile = TextSaveFile.Read("mySettings.txt");

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
