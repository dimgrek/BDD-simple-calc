Feature: ATM-test
	In order to check the ATM work
	As a customer
	I want to be given the cash
	When requested


Scenario: Account is in credit
	Given Account is in credit
	And the card is valid
	And the dispenser contains cash
	When the customer requests cash
	Then ensure the account is debited
	And ensure cash is dispenced
	And ensure card is returned
