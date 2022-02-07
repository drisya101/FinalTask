Feature: Shareskill


Scenario:   Add Share skill 
	Given The seller enters the following Shareskill data 
			| Title           | Description           | Category         | Sub Category | Tags   | Service Type    | Location Type | Available days | Skill Trade    | Skill-Exchange | Work Samples | Active |
			| Test Engineer | Automation | Programming & Tech | QA           | Tester | Hourly basis service | On-site       | Mon            | Skill-exchange | Automation     |              | Active |
                 
	When  clicks on "Save" action button 
	Then  Alert message "Service Listing Added successfully" is displayed on top right of the application.