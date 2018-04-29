Feature: PropertyreteLogin
	In order to do things on the site
	I have to Log in

@mytag
Scenario: Login
	Given I navigate to the url propertyrete.com
	And I click on Login
	And I input your email
	And I input your password
	When I press Login
	Then I should be taken to my propertyrete profile page

	Scenario: Invalid Login
	Given I navigate to the url propertyrete.com
	And I click on Login
	And I input your email
	And I input your wrong password
	When I press Login
	Then I should be shown an error message
