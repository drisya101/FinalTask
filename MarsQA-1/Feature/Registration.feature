Feature: Registration


@mytag
Scenario: Create new user account
	Given the first name  is "First"
	And the last name is "Last"
	And the Emali address is "FirstLast@some.com"
	And the password is "password@1"
	And the Confirm password is "password@1"
	And the user check on I agree to the terms and conditions
	When the user cliks on join
	Then the user acoout should be created, the alert message "Registration successful" will be displayed on top right of the application.