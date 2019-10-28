Feature: SystemPermissions
	     Permissions handling on first launch for access to contacts
	
@Sanity
Scenario: Give access
	Given I have launched the application
	When I press allow
	Then I see the Contacts List Page

# I havent had a chance to automate this scenario 
#@mytag
#Scenario: Deny access
	#Given I have launched the application
	#When I press Deny
	#Then I see the No Permission deined pop up
	#When I press Ok
	#Then I see Permissions Pop up
	#When I press allow
	#Then I see the Contacts List Page


