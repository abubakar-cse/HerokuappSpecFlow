Feature: DynamicControls
	I am an user
	I want to chnage the state
	To able to send randdom texts


Scenario: dynamic controls and send random text
	Given I got to 'Dynamic Controls' on the Main Page
	When I click the 'Enable' on the Dynamic Controls Page
	And I input random texts
	Then display the entered random texts