Feature: TMFeature
	As a TurnUp portal admin
	I would like to create, edit and delete time and material records
	So that I can manage my employees' time and materials successfully.

@mytag
Scenario: create time and material record with valid details
	Given I logeed into turnup portal successfully 
	And I navigate to time and material page
	When I create a time and material record
	Then the record should be created successfully

Scenario Outline: edit existing time and material record with valid details
	Given I logeed into turnup portal successfully 
	And I navigate to time and material page
	When I update '<Description>' an existing time and material record
	Then the record should have an updated '<Description>'

	Examples:
	| Description  |
	| Time         |
	| Material     |
	| EditedRecord |



