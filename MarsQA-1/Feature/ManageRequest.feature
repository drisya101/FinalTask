Feature: Manage Request
	
@mytag
Scenario: Test to view the list of Received Requets records sucessfully
	Given the user has received the following requests
	| Category          | Title				|
	| Graphics & Design | Postman			|        
	| Business			| Swagger UI		| 
	| Graphics & Design	| Postman			|		
	| Graphics & Design	| Automation		|	
	| Business			| Manual testing	|
	When the user clicks "Received Requests" link under Manage Requests tab
	Then the Received Requests list page is displayed with the following data
		| Category          | Title          | Message                   | Sender     | Status    | Type     | Date           |
		| Graphics & Design | Postman        | Test Message              | Darshana   | Completed | Exchange | 14th Sep, 2021 |
		| Business          | Swagger UI     | Test Message              | Darshana   | Accepted  | Exchange | 13th Sep, 2021 |
		| Graphics & Design | Postman        | Test Message              | Darshana   | Accepted  | Exchange | 13th Sep, 2021 |
		| Graphics & Design | Automation     | Test Message              | Darshana   | Declined  | Exchange | 13th Sep, 2021 |
		| Business          | Manual testing | Test Message				 | Darshana   | Declined  | Exchange | 13th Sep, 2021 |
