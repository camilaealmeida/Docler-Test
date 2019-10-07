using System;
using DoclerTest.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DoclerTest.Steps
{
    [Binding]
    public class HomePageSteps : BaseTest
    {
        private static HomePageObject homePage;
        private static FormPageObject formPage;

        [BeforeTestRun]
        public static void Init()
        {
            homePage = new HomePageObject(GetDriver());
            formPage = new FormPageObject(GetDriver());
        }

        #region methods

        [Given(@"user access Home page")]
        public void GivenUserAccessHomePage()
        {
            homePage.NavigateToHomePage();
        }

        [Given(@"user is on Home page")]
        public void GivenUserIsOnHomePage()
        {
            Assert.IsTrue(homePage.IsOnHomePage(GetDriver().Url),
                "Home page not displayed.");
        }

        [Then(@"message ""(.*)"" in ""(.*)"" tag")]
        public void ThenMessageInTag(string p0, string p1)
        {
            var element = p1 == "h1" ? homePage.HeadingText : homePage.PText;
            Assert.AreEqual(p0, element.Text);
            Assert.AreEqual(p1, element.TagName);
        }

        [Then(@"Home page is displayed")]
        public void ThenHomePageIsDisplayed()
        {
            Assert.IsTrue(homePage.IsOnHomePage(GetDriver().Url),
                "Home page was not displayed.");
        }

        [Then(@"home button is active")]
        public void ThenHomeButtonIsActive()
        {
            Assert.IsFalse(formPage.IsFormButtonActive(),
                "Form button was active.");
            Assert.IsTrue(homePage.IsHomeButtonActive(),
               "Home button was not active.");
        }

        #endregion
    }
}
