Feature: Coumpound Escalation
	In order to learn about the price increase
	As a concerned citizen
	I want to apply compound escalation to a value using the Calculator

Scenario: Escalate the value
	Given I chose 100 as first number
	And I chose 10 as escalation value
	And I chose 2 as the number of Escalation Years
	When I press calculate
	Then the result should return 121 on the screen