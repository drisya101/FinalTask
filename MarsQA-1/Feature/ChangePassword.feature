Feature: Change Password


@mytag
Scenario: 01 Test update Change password sucessfully
    Given seller enter current password  as "bdd.demo123" 
	And seller enter New Password as "bdd.demo123" 
	And seller enter Confirm Password as "bdd.demo123" 
	When Clicks on Saveaction button 
	Then change password should be updated.The alert message,"Password Changed Successfully" will be displayed

