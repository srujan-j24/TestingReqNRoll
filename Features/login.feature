Feature: login

login test 

Background: 
	Given User is on the orange hrm login page


@regression,@functional
Scenario: Verify login with valid credentials

	When User enters the username "Admin" and password "admin123"
	And User clicks on submit button
	Then User is navigated to Home page



@sanity

Scenario Outline: Verify login with test parameters
	When User enters the username "<username>" and password "<password>"
	And User clicks on submit button
	Then User is navigated to Home page
	Then User selected city and country information
	| city   | country |
	| delhi  | India   |
	| boston | USA     |

Examples:
	| username | password |
	| Admin    | admin123 |
	| Ad       | min      |
	| adm      | 123a     |



