// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DoclerTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Home Page")]
    public partial class HomePageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "HomeFeature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Home Page", "    As an user of website\n    I want to validate the Home page features ", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
#line 6
    testRunner.Given("user access Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
    testRunner.Then("Docler Holding logo is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 8
    testRunner.And("title should be \"UI Testing Site\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("REQ-UI-03 and REQ-UI-04 - Home button must navigate to Home page")]
        public virtual void REQ_UI_03AndREQ_UI_04_HomeButtonMustNavigateToHomePage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("REQ-UI-03 and REQ-UI-04 - Home button must navigate to Home page", null, ((string[])(null)));
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 11
    testRunner.Given("user access Form page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
    testRunner.When("I click on home button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
    testRunner.Then("Home page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
    testRunner.And("home button is active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("REQ-UI-08 and REQ-UI-04 - UI Testing button must navigate to Home page")]
        public virtual void REQ_UI_08AndREQ_UI_04_UITestingButtonMustNavigateToHomePage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("REQ-UI-08 and REQ-UI-04 - UI Testing button must navigate to Home page", null, ((string[])(null)));
#line 16
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 17
    testRunner.Given("user access Form page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
    testRunner.When("I click on UITesting button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
    testRunner.Then("Home page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
    testRunner.And("home button is active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("REQ-UI-09 - validade h1 text")]
        public virtual void REQ_UI_09_ValidadeH1Text()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("REQ-UI-09 - validade h1 text", null, ((string[])(null)));
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 23
    testRunner.Given("user is on Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
    testRunner.Then("message \"Welcome to the Docler Holding QA Department\" in \"h1\" tag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("REQ-UI-10 - validade p text")]
        public virtual void REQ_UI_10_ValidadePText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("REQ-UI-10 - validade p text", null, ((string[])(null)));
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 27
    testRunner.Given("user is on Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
    testRunner.Then("message \"This site is dedicated to perform some exercises and demonstrate automat" +
                    "ed web testing.\" in \"p\" tag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
