using System;
using DoclerTest.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DoclerTest.Steps
{
    [Binding]
    public class ErrorPageSteps : BaseTest
    {
        private static ErrorPageObject errorPage;

        [BeforeTestRun]
        public static void Init()
        {
            errorPage = new ErrorPageObject(GetDriver());
        }

        [Then(@"an (.*) error code should happen")]
        public void ThenAnErrorCodeShouldHappen(int p0)
        {
            string error404 = "404";
            Assert.IsTrue(errorPage.ErrorMessage.Text.Contains(error404),
                "Error 404 was not found.");
            Assert.IsTrue(errorPage.GetPageTitle.Contains(error404),
                "Error 404 was not found.");
        }
    }
}
