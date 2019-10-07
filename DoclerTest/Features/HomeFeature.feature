Feature: Home Page
    As an user of website
    I want to validate the Home page features 

Background: REQ-UI-01 and REQ-UI-02 - Verify logo and page title
    Given user access Home page 
    Then Docler Holding logo is present
    And title should be "UI Testing Site"

Scenario: REQ-UI-03 and REQ-UI-04 - Home button must navigate to Home page
    Given user access Form page
    When I click on home button
    Then Home page is displayed
    And home button is active

Scenario: REQ-UI-08 and REQ-UI-04 - UI Testing button must navigate to Home page
    Given user access Form page
    When I click on UITesting button
    Then Home page is displayed
    And home button is active
 
Scenario: REQ-UI-09 - validade h1 text 
    Given user is on Home page
    Then message "Welcome to the Docler Holding QA Department" in "h1" tag

Scenario: REQ-UI-10 - validade p text
    Given user is on Home page
    Then message "This site is dedicated to perform some exercises and demonstrate automated web testing." in "p" tag
            