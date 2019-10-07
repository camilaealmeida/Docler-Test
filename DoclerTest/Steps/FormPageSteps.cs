using System;
using DoclerTest.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DoclerTest.Steps
{
    [Binding]
    public class FormPageSteps : BaseTest
    {
        private static FormPageObject formPage;
        private static HomePageObject homePage;

        [BeforeTestRun]
        public static void Init()
        {
            formPage = new FormPageObject(GetDriver());
            homePage = new HomePageObject(GetDriver());
        }

        #region methods

        [Given(@"user access Form page")]
        public void GivenUserAccessFormPage()
        {
            formPage.NavigateToFormPage();
        }

        [Then(@"Form page is displayed")]
        public void ThenFormPageIsDisplayed()
        {
            Assert.IsTrue(formPage.IsOnFormPage(GetDriver().Url),
                "Form page not displayed.");
        }

        [Then(@"form button is active")]
        public void ThenFormButtonIsActive()
        {
            Assert.IsTrue(formPage.IsFormButtonActive(),
                 "Form button was not active.");
            Assert.IsFalse(homePage.IsHomeButtonActive(),
                "Home button was active.");
        }

        [Then(@"user can see one input box")]
        public void ThenUserCanSeeOneInputBox()
        {
            int count = 0;
            int max = 1;
            var inputs = GetDriver().FindElements(By.TagName("input"));

            foreach (var input in inputs)
            {
                if (input.GetAttribute("type").Contains("text"))
                {
                    count++;
                }
            }

            Assert.AreEqual(max, count, "Mismatch: input textbox");
        }

        [Then(@"one submit button")]
        public void ThenOneSubmitButton()
        {
            int count = 0;
            int max = 1;
            var buttons = GetDriver().FindElements(By.TagName("button"));

            foreach (var button in buttons)
            {
                if (button.GetAttribute("type").Contains("submit"))
                {
                    count++;
                }
            }

            Assert.AreEqual(max, count, "Mismatch: submit button");
        }

        [When(@"I click on go button")]
        public void WhenIClickOnGoButton()
        {
            formPage.ClickGoSubmitButton();
        }

        [Given(@"user enter ""(.*)""")]
        public void GivenUserEnter(string p0)
        {
            formPage.SendKeysToInputText(p0);
        }

        [Then(@"a message ""(.*)"" is displayed")]
        public void ThenAMessageIsDisplayed(string p0)
        {
            Assert.AreEqual(p0, formPage.HelloResultText.Text);
        }

        #endregion
    }
}
