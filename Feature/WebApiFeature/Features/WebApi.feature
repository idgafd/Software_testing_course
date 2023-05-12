Feature: WebApi

@Upload
Scenario: Upload file
	Given check file to upload exists on pc
	When upload file
	Then file is uploaded to Dropbox

@Metadata
Scenario: Show file metada
	Given file to chekc metadat on exists on Dropbox
	When get file metada
	Then check that metadata is correct

@Delete
Scenario: Delete file
	Given file to delete exists on Dropbox
	When delete file
	Then file is deleted from Dropbox