Feature: Addition
    In order to avoid silly mistakes
    As a math idiot
    I want to be told the sum of two numbers
    
@mytag
Scenario: Add two numbers
    Given I have entered num into the calculator
| num |
| 32 |
| 34 |
| 33 |
    When I press add
    Then the result num should be on the screen
| num |
| 1024 |
| 1156 |
| 1089 |   