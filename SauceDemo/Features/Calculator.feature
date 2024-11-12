Feature: Login

@mytag
Scenario: Successful Login
	Given I am on the login page
	When I enter valid credentials
	Then I should be redirected to the home page

@mytag
Scenario: Unsuccessful Login
	Given I am on the login page
	When I enter invalid credentials
	Then I should see an error message