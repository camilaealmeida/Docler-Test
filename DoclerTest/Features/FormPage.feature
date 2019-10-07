Feature: Form Page
    As an user of website
    I want to validate all Form page features

Background: REQ-UI-01 and REQ-UI-02 - Verify logo and page title
    Given user access Form page 
    Then Docler Holding logo is present
    And title should be "UI Testing Site"

Scenario: REQ-UI-05 and REQ-UI-06 - Form button must navigate to Form page 
    Given user access Home page
    When I click on form button
    Then Form page is displayed
    And form button is active

Scenario: REQ-UI-11 - Validade input box and submit button
    Then user can see one input box
    And one submit button

Scenario Outline: REQ-UI-12 - Validate the welcome message
    Given user enter "<value>"
    When I click on go button
    Then a message "Hello <value>!" is displayed
    And Docler Holding logo is present
    And title should be "UI Testing Site"

        Examples: 
        |value     |
        |John      |
        |Sophia    |
        |Charlie   |
        |Emily     |
        |camila    |
        |João      |
        |12345     |
