Feature: ManageListingsEdit


@mytag
Scenario:Test update Shareskill sucessfully
	Given Given The seller enters the following Shareskill data 
			| Title    | Description                | Category          | Sub Category       | Tags      | Service Type         | Location Type | Available days | Skill Trade | Credit | Work Samples | Active |
			| Cypress | All Cypress | Digital Marketing |Content Marketing   | Cypress  | Hourly basis service | Online        | Sat            | Credit      | 8      |              | Hidden |
                 
	When  clicks on 'Save' action button 
	Then  Alert message "Service Listing updated successfully" is displayed 