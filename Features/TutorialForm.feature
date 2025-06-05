Feature: Feature1

Tutorial form

@tag1
Scenario: Successfully fill and submit the practice form
    Given I navigate to the Selenium practice form page
    When I enter "John Doe" as Name
    And I enter "john.doe@example.com" as Email
    And I select "Male" as Gender
    And I enter "1234567890" as Mobile Number
    And I enter "01 Jan 1990" as Date of Birth
    And I enter "Computer Science" as Subject
    And I select "Reading" as Hobbies
    And I enter "123 Main Street, Anytown, USA" as Current Address
    And I select "NCR" as State
    And I select "Agra" as City
    And I click on the Submit button
    Then the form should be submitted successfully