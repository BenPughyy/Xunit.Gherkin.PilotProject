Feature: Escalation
	In order to learn about the price increase
	As a concerned citizen
	I want to apply escalation to a value using the Calculator

Scenario: Add two numbers
	Given I chose 100 as the value
	And I chose 15 as escalation value
	When I press calculate
	Then the result should return 115 on the screen