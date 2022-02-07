Feature: ProfileChat
	
Scenario: Chat option in Profile Page
Given User is on Profile Tab
And the user Clicks on Chat tab Chat screen opens
When the user inputs name in search input box
Then Chats between the input name and user should be visible 
And to send message add message in input box
And Clicks on send button
