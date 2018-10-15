Feature: Photos

@positive
Scenario: Image from photo response can be saved on disc
	Given Photo with id "3" is requested
	When Image url from response is requested
	Then Response status code is "200"
	And Image is saved on disc
