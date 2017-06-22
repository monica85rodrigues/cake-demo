Feature: Values

@mytag
Scenario: There are two values in the system
	Given there are two values in the system
	When I retrieve list of all values
	Then I get a list with two values