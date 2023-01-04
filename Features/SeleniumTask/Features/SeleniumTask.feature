Feature: AddPayGrades

@AddNewCurrency
Scenario: AddNewCurrency
	Given login to the page
	And go to admin
	And go to pay grades
	And add pay grade
	When added job title and new currency
	Then check that currency added properly

@checkPayGrade
Scenario: Check that pay grade added properly
	Given delete new currency
	Then check that pay grade added properly 