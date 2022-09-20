Feature: MultiplyTwoNumbers
	In order to learn Math
	As a regular human
	I want to multiply two numbers using Calculator

Scenario: Multiply two numbers
	Given I chose 12 as first number
	And I chose 7 as second number
	When I press multiply
	Then the result should be 84 on the screen