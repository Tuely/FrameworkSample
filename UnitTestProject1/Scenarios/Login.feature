Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

	Background: 
	Given I navigate into url

@mytag
Scenario: Create a new user
	Given click login button
	And I enter signup information details
	| Title | FirstName |
	| Mr    | Test      |
	