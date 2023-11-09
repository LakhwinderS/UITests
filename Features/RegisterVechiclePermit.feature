Feature: Unregister Vechicle Permit

As a user I want to register my unregister vehicle permit
@UvPTests
Scenario: Register Vehicle Permit
	Given Navigate to vic road register vehicle page 'https://www.vicroads.vic.gov.au/registration/limited-use-permits/unregistered-vehicle-permits/get-an-unregistered-vehicle-permit'
	When Enter vehicle detail 'PassengerVehicle','Sedan','8','08/11/2023' and click on Next
	Then Click on Calculate ,validate the amount '$57.80' and Click on Next
	Then Validate the Select permit type” is displayed
