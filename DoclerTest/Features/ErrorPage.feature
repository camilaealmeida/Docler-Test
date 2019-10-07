Feature: Error Page
    As an user of website
    I want to validate the Error page features
    
Scenario: REQ-UI-07 - Click on Error button should get 404 HTTP response code
    Given user access Home page
    When I click on error button
    Then an 404 error code should happen   