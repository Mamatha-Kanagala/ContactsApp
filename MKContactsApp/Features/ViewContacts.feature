Feature: ViewContacts
	I want to view contacts to see if they have correct information 
@mytag
Scenario: View Contact
	Given I am on the Contacts List page
	When I press on a Contact
	Then I see the Contact Info page

