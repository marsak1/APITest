Feature: Users
	Users should be able to submit GET, POST, PUT and DELETE requests to api
	
@positive
Scenario: Users list request returns proper data
	When Users list is requested
	Then Response status code is "200"
	And Response users schema is correct

@positive
Scenario: User request by id returns proper data
	When User with id "1" is requested
	Then Response status code is "200"
	And User id is correct
	And Response user schema is correct

@positive
Scenario: Adding new user
	Given User object is filled with random data
	When User upload his data
	Then Response status code is "201"
	And User is correctly added

@positive
Scenario Outline: User email can be updated
	Given User with id "<userId>" is requested
	When Selected user "<userId>" email update is requested
	Then User email is updated

	Examples: 
	| userId |
	| 3      |

@positive
Scenario: User can be removed 
	When Delete user with id "3" is requested
	Then Response status code is "200"
	And Response is empty

@negative
Scenario: Add new user with existing id
	When User upload his data with id "1" and other data is random
	Then Response status code is "500"
	And Error message "Insert failed, duplicate id" appears



