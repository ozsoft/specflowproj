Feature: Create Timesheet
    Whilst adding a timesheet
    adding a new timesheet does not store the added timesheet 
    unless you click on (+) button to add a new empty row to then add the item successfully


@browser: chrome
Scenario Outline: Adding new timesheet with a single row
    Given I navigate to homepage and clicked on create new
    When I create new timesheet page for a single row with <employeeId> <hourlyRate> <day> <hours> <minutes>
    Then The result should be an error on saving the timesheet

Examples:
| employeeId    | hourlyRate    | day          | hours      | minutes   |
| CPD400        | 400           | Wednesday    | 10         | 40        |

@timesheet
Scenario Outline: Adding new timesheet with two rows
    Given I navigate to homepage and clicked on create new
    When I create new timesheet page for a double row with <employeeId> <hourlyRate> <day> <hours> <minutes>
    Then The result should be added to the list successfully with <employeeId> <hourlyRate> <day> <hours> <minutes>

Examples:
| employeeId    | hourlyRate    | day          | hours      | minutes   |
| CPD400        | 400           | Wednesday    | 10         | 40        |

@timesheet
Scenario Outline: Adding new timesheet with two rows with data
    Given I navigate to homepage and clicked on create new
    When I create new timesheet page with double row using data <employeeId> <hourlyRate> <day> <hours> <minutes>
    Then The result should be added to the list successfully with <employeeId> <hourlyRate> <day> <hours> <minutes>

Examples:
| employeeId    | hourlyRate    | day          | hours      | minutes   |
| CPD400        | 400           | Wednesday    | 10         | 40        |
| CPD500        | 300           | Wednesday    | 10         | 40        |
| CPD500        | 300           | Wednesday    | 10         | 40        |