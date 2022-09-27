Feature: Single Resource Object
	As a user of MURI
	I want to be sure that I can get the correct values from my Resource Objects when reporting

Scenario: Single Resource Object Calculations
	Given I build one resource object
	When I press calculate
	Then it should display the correct outputs: 25 Period Value and 250 Report Total