Feature: SentRequests
	

@mytag
Scenario:01 Test User Sent A SentRequets record sucessfully
	Given  User has Sent the following requests
	| Category          | Title            | Message | Recipient | 
	| Business          | Business Writing | Test Message      | SomeRecepient   | 
	| Video & Animation | Sketching        | Test Message      | SomeRecepient   | 
	| Fun & Lifestyle   | Dance Basics     | Test Message      | SomeRecepient   | 
	| Fun & Lifestyle   | Life Skills      | Test Message      | SomeRecepient   | 
	| Fun & Lifestyle   | Random          | Test Message      | SomeRecepient   | 
	When  User clicks "Sent Requests" link under Manage Requests tab
	Then  User Sent Requests list Page is displayed with the following data
	| Category          | Title            | Message | Recipient | Status    | Type     | Date           |
	| Business          | Business Writing | Test Message      | SomeRecepient   | Withdrawn | Exchange | 14th Sep, 2021 |
	| Video & Animation | Sketching        | Test Message      | SomeRecepient   | Withdrawn | Exchange | 14th Sep, 2021 |
	| Fun & Lifestyle   | Dance Basics     | Test Message      | SomeRecepient   | Withdrawn | Exchange | 14th Sep, 2021 |
	| Fun & Lifestyle   | Life Skills      | Test Message      | SomeRecepient   | Withdrawn | Exchange | 14th Sep, 2021 |
	| Fun & Lifestyle   | Random         | Test Message      | SomeRecepient   | Withdrawn | Exchange | 14th Sep, 2021 |	