Feature: EventFeature

As an authenticated user, I would like to manage Event content by adding, editing, and deleting them successfully.

Scenario: A user adds an event posting 
	Given login to TADemo website
	And navigate to event page
	When add an event
	Then the event should be created successfully

Scenario: A user edits an event posting
	Given click edit event 
	When edit the event
	Then the event should be edited successfully

Scenario: A user deletes an event posting
	Given click delete event
	When click confirm delete
	Then the event should be deleted successfully