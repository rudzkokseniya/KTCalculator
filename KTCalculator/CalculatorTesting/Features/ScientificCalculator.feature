Feature: ScientificCalculator
As a 3rd grader
I want to make some basic calculations using the calculator app
In order to finish my math homework

Background: 
	Given The calculator application is started

Scenario: TestScientificCalculator
	When I select Scientific calculator view
		And I input 12 into calculator
		And I add 999 to current result
	Then 1011 is displayed as result
		
	When I store the displayed result to calculator memory
		And I input 19 into calculator
		And I square the result
	Then 361 is displayed as result
