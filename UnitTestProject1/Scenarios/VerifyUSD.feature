Feature: VerifyUSD

Background:
	Given I navigate into url

@test
Scenario: Verify USD
	Given I search for 'GBP TO USD'
	Then I validate details