Feature: Login and click my timesheet
	
	
Scenario:Login scenario of OrangeHRM
	#steps - A given step
	Given user is at home page
	When i provide username and password and click login button
	Then user should be at main page
	And verify title	 
	
	