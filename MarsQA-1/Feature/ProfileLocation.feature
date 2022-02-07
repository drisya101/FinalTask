Feature: ProfileLocation


@mytag
Scenario: update First name and Last name 
	Given Seller updates First Name as "FirstName" 
	And  Seller updates Last Name as "LastName" 
	When Clicks on Save action button 
	Then Updated name "FirstName LastName" should be displayed below the profile image


@mytag
Scenario:  update Availability 
	Given Seller Select Availability as "Full Time"
	Then Availability should be updated. The alert message,"Availability updated" will be displayed on top right of the application.

@mytag
Scenario:  update Hours 
	Given  seller Select Hours as "More than 30hours a week"	
	Then  Hours should be updated. The alert message,"Availability updated" will be displayed on top right of the application.

@mytag
Scenario:  update Earn Target 
	Given  seller Select Earn Target as"Between $500 and $1000 per month"	
	Then  Earn Target should be updated. The alert message,"Availability updated" will be displayed on top right of the application.