Feature: AddCertification


@mytag
 Scenario: Add Certification 
	Given Seller enter Certificate as "AZURE"
	And   Seller enter CertificateFrom as "Microsoft"
	And   select Year as "2022"                        
	When  Clicks on Add button on Addcertification page
	Then  Certificate should be added to the  profile. The Alert message "AZURE has been added to your certification" is displayed on top right of the application.

@mytag		
 Scenario: Update Certification 
		Given seller Updates Certificate as "ISTQB"
		And   updates Certificate From as "IBM"
		And   select Certificate Year as "2022"  
		When  clicks on Update button on UpdateCertification page
		Then  certification should be updated. The alert message, "ISTQB has been updated to your certification" will be displayed on top right of the application.

@mytag		
 Scenario: Delete Certification 
		When  Seller select to delete Certification "ISTQB" 
		Then  Certification should be deleted. The alert message, "ISTQB has been deleted from your certification" will be displayed on top right of the application.





	









