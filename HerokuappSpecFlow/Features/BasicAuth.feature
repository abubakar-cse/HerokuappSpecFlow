Feature: BasicAuth
	I am an user
	I want to Login
	To able to get access

Scenario: Basic Authentication
	Given I got to 'Basic Auth' on the Main Page
	When I input 'admin' as username and 'admin' password on the LogIn Page
	Then Success message displayed on the BasicAuth Page
