Feature: Text Save File

Background:
	Given I create a new text save file

Scenario: Read/Write String
	When I add the string 'myString' with value 'DESKTOP-123' to the settings file
	And I write the settings file
	And I read the settings file
	Then the string 'myString' with value 'DESKTOP-123' is in the settings file

Scenario: Read/Write Char
	When I add the char 'myChar' with value 'A' to the settings file
	And I write the settings file
	And I read the settings file
	Then the char 'myChar' with value 'A' is in the settings file

Scenario: Read/Write DateTime
	When I add the datetime 'myDateTime' with value '11/15/2021 8:19:04 PM' to the settings file
	And I write the settings file
	And I read the settings file
	Then the datetime 'myDateTime' with value '11/15/2021 8:19:04 PM' is in the settings file

Scenario: Read/Write Bool
	When I add the bool 'myBool' with value 'true' to the settings file
	And I write the settings file
	And I read the settings file
	Then the bool 'myBool' with value 'true' is in the settings file

Scenario: Read/Write Sbyte
	When I add the sbyte 'mySbyte' with value '-123' to the settings file
	And I write the settings file
	And I read the settings file
	Then the sbyte 'mySbyte' with value '-123' is in the settings file

Scenario: Read/Write Short
	When I add the short 'myShort' with value '-12345' to the settings file
	And I write the settings file
	And I read the settings file
	Then the short 'myShort' with value '-12345' is in the settings file

Scenario: Read/Write Int
	When I add the int 'myInt' with value '-1234567' to the settings file
	And I write the settings file
	And I read the settings file
	Then the int 'myInt' with value '-1234567' is in the settings file

Scenario: Read/Write Long
	When I add the long 'myLong' with value '-1234567890' to the settings file
	And I write the settings file
	And I read the settings file
	Then the long 'myLong' with value '-1234567890' is in the settings file

Scenario: Read/Write Byte
	When I add the byte 'myByte' with value '123' to the settings file
	And I write the settings file
	And I read the settings file
	Then the byte 'myByte' with value '123' is in the settings file

Scenario: Read/Write UShort
	When I add the ushort 'myUShort' with value '12345' to the settings file
	And I write the settings file
	And I read the settings file
	Then the ushort 'myUShort' with value '12345' is in the settings file

Scenario: Read/Write UInt
	When I add the uint 'myUInt' with value '1234567' to the settings file
	And I write the settings file
	And I read the settings file
	Then the uint 'myUInt' with value '1234567' is in the settings file

Scenario: Read/Write ULong
	When I add the ulong 'myULong' with value '1234567890' to the settings file
	And I write the settings file
	And I read the settings file
	Then the ulong 'myULong' with value '1234567890' is in the settings file

Scenario: Read/Write Double
	When I add the double 'myDouble' with value '123.456' to the settings file
	And I write the settings file
	And I read the settings file
	Then the double 'myDouble' with value '123.456' is in the settings file

Scenario: Read/Write Float
	When I add the float 'myFloat' with value '123.4567' to the settings file
	And I write the settings file
	And I read the settings file
	Then the float 'myFloat' with value '123.4567' is in the settings file

Scenario: Read/Write Decimal
	When I add the decimal 'myDecimal' with value '123.45678' to the settings file
	And I write the settings file
	And I read the settings file
	Then the decimal 'myDecimal' with value '123.45678' is in the settings file