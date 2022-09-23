Feature: Escalation
	In order to learn about the price increase
	As a concerned citizen
	I want to apply escalation to a value using the Calculator

Scenario: Escalate the value
	Given I chose 100.00 as first number
	And I chose 12.5 as escalation value
	When I press calculate
	Then the result should return 115 on the screen