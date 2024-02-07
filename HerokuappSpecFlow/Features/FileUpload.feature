Feature: FileUpload

Scenario: Uploading a file
	Given I got to 'File Upload' on the Main Page
	When I upload the file
	Then the uploaded file should have the correct name
