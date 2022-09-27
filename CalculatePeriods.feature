Feature: Calculate Period Length
	As someone who uses MURI
	I want to calculate how many days are in a given period, given the end date and start date

Scenario: Calculate Period Length
	Given I select 31.12.2022 as an start date
	And I select 31.12.2024 as an end date
	When I press calculate
	Then the result should show 731 on the screen