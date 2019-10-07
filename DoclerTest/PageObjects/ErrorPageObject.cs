using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DoclerTest.PageObjects
{
    public class ErrorPageObject : BasePageObject
    {
        private string errorURL = "http://uitest.duodecadits.com/error";

        #region elements

        public IWebElement ErrorMessage =>
            GetDriver.FindElement(By.TagName("h1"));

        #endregion

        public ErrorPageObject(IWebDriver driver)
            : base(driver)
        {
        }

        #region methods

        public bool IsOnErrorPage(string url)
        {
            return errorURL == url;
        }

        #endregion
    }
}
