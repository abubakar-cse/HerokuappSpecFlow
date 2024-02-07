Feature: Alerts
	I am an user
	I want to handle alert
	To be able to accept is

Scenario: Alert handling
	Given I got to 'JavaScript Alerts' on the Main Page
	When I generate JS alert on the JavaScript Alerts Page
	And I accept the alert
	Then Ok message is displayed on JavaScript Alerts Page
