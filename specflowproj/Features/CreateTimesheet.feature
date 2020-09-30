Feature: Adding a new timesheet
    Whilst adding a timesheet
    adding a new timesheet does not store the added timesheet 
    unless you click on (+) button to add a new empty row to then add the item successfully
    

Scenario: Adding new timesheet with a single row
    Given I navigate to homepage and clicked on create new
    When I create new timesheet page for a single row
    Then The result should be an error on saving the timesheet

Scenario: Adding new timesheet with two rows
    Given I navigate to homepage and clicked on create new
    When I create new timesheet page for a double row
    Then The result should be added to the list successfully