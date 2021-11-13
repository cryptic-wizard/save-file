Feature: Settings Text File

Background:
	Given I create a new settings file

Scenario: Read/Write String
	When I add the string 'UserWorkstation' with value 'DESKTOP-123' to the settings file
	And I write the settings file
	And I read the settings file
	Then the string 'UserWorkstation' with value 'DESKTOP-123' is in the settings file