Feature: AddProfileEducation

mytag
 Scenario: Add Education 
	Given Seller enter UniversityName as "AUT"
	And   Select CountryOfUniversity as "New Zealand"
	And   Select Title as "B.Tech"
	And   Enter Degree as "4Years"
	And   Select YearOfGreaduation as "2019"                      
	When  Clicks on Add button on AddEducation page
	Then  Education should be added to the  profile. The Alert message "Education has been added" is displayed on top right of the application.

	
@mytag
 Scenario: Update Education
		Given seller updates education as "Victoria"
		And   updates CountryOfUniversity as "China"
		And   updates Title as "M.Tech"
		And   updates Degree as "2Years"
		And   updates YearOfGreaduation as "2020" 
		When  clicks on Update button on Updateeducation page
		Then  Education should be updated. The alert message, "Education as been updated" will be displayed on top right of the application.
@mytag		
 Scenario: Delete Education
		When  Seller select to delete Educaion "Victoria" 
		Then  Education should be deleted. The alert message, "Education entry successfully removed" will be displayed on top right of the application.


















