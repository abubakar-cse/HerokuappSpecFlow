Feature: File Download Feature

Scenario: User downloads a file
	Given I got to 'File Download' on the Main Page
	When I click the download link for the file "<fileName>"
	Then the file "<fileName>" should be downloaded successfully
