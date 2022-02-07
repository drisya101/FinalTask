Feature: Add Skills

@mytag
 Scenario: 01 Test Add Skills sucessfully
		Given seller enter skill as "C#"
		And   select skill level as "Beginner" 
		When  clicks on Add button on Addskill page
		Then  Skill should be added to the  profile. The alert message, "C# has been added to your skills" will be displayed on top right of the application.

@mytag
 Scenario: 02 Test Update Skills sucessfully
		Given seller Updates skill as "Quality Engineer"
		And   updates skill level as "Expert" 
		When  clicks on Update button on Updateskill page
		Then  Skill should be updated. The alert message, "Quality Engineer has been updated to your skills" will be displayed on top right of the application.

@mytag		
 Scenario: 03 Test Delete Skill sucessfully
		When  Seller select to delete Skill "Quality Engineer" 
		Then  Skill should be deleted. The alert message,"Quality Engineer has been deleted" will be displayed on top right of the application.

