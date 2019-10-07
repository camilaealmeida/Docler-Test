# Docler Holding Home Work - QA Position

UI automation testing project using Selenium, NUnit and SpecFlow

#### Requirements to Run 

- .NET Core 2.2+
- Dotnet CLI
- Visual Studio 2015+
- chromedriver.exe mapped in PATH Environment Variable (Windows)

**Via Visual Studio**

- Clone the project
- Open the DoclerTest.sln file
- Build the project
- Go to Test Explorer/Unit Tests window > click on 'Run all' button

**Via Terminal/CMD**
	
- Clone the project
- Go to terminal/cmd > navigate to DoclerTest folder and run the follow commands:

```sh
dotnet build DoclerTest
dotnet test DoclerTest --logger trx
```

#### Test Results

- Total tests: 14
- Passed: 13
- Failed: 1
- Total time: 14.3164 Seconds

**Failed tests**

```sh
### 1 ###
- REQ_UI_12

Steps:

Given user access Form page
-> done: FormPageSteps.GivenUserAccessFormPage() (0.1s)
Then Docler Holding logo is present
-> done: BaseSteps.ThenDoclerHoldingLogoIsPresent() (0.0s)
And title should be "UI Testing Site"
-> done: BaseSteps.ThenTitleShouldBe("UI Testing Site") (0.0s)
Given user enter "João"
-> done: FormPageSteps.GivenUserEnter("João") (0.2s)
When I click on go button
-> done: FormPageSteps.WhenIClickOnGoButton() (0.4s)
Then a message "Hello João!" is displayed
-> error:   Expected string length 11 but was 16. Strings differ at index 8.
Expected: "Hello João!"
But was:  "Hello Jo%C3%A3o!"
```
