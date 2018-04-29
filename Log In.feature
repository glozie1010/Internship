Feature: LogIn
	In order to do anything to the site
	you should log in

@mytag
Scenario: Valid Login
	Given I navigate to the url
	And I click on log in
	And I input my username 
	And I input my password
	When I click on log in
	Then I should be taken to my profile page



	Scenario: Invalid Login
	Given I navigate to the url
	And I click on login
	And I input my username 
	And I input my invalid password
	When I click on log in 
	Then I should be given an error message
