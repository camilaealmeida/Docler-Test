using System;
using DoclerTest.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DoclerTest.Steps
{
    [Binding]
    public class BaseSteps : BaseTest
    {
        private static BasePageObject basePage;

        [BeforeTestRun]
        public static void Init()
        {
            basePage = new BasePageObject(GetDriver());
        }

        #region methods

        [When(@"I click on UITesting button")]
        public void WhenIClickOnUITestingButton()
        {
            basePage.ClickUITestingButton();
        }

        [When(@"I click on home button")]
        public void WhenIClickOnHomeButton()
        {
            basePage.ClickHomeButton();
        }

        [When(@"I click on form button")]
        public void WhenIClickOnFormButton()
        {
            basePage.ClickFormButton();
        }

        [When(@"I click on error button")]
        public void WhenIClickOnErrorButton()
        {
            basePage.ClickErrorButton();
        }

        [Then(@"Docler Holding logo is present")]
        public void ThenDoclerHoldingLogoIsPresent()
        {
            Assert.IsTrue(basePage.DhLogo.Displayed,
                "Docler Holding logo was not present.");
        }

        [Then(@"title should be ""(.*)""")]
        public void ThenTitleShouldBe(string p0)
        {
            Assert.AreEqual(p0, basePage.GetPageTitle);
        }

        [AfterTestRun]
        public static void AfterTest()
        {
            CloseDriver();
        }

        #endregion
    }
}
