Feature: HotelPlannerHotelList
	In order see the Hotel List
	As a User
	I want to navigate to HotelPlanner website

@HotelPlannerHotelList
Scenario: Check the Hotel List
	Given I Navigate to HotelPlanner
	When I Click on Hotel Deals
	And I Select the city 
	And I Select the check in date and and check out date
	And I Select the Number of Rooms
	Then I See the List of the Hotels

