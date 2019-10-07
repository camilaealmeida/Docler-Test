using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DoclerTest.PageObjects
{
    public class HomePageObject : BasePageObject
    {
        private string homeURL = "http://uitest.duodecadits.com/";

        #region elements

        public IWebElement PText =>
            GetDriver.FindElement(By.TagName("p"));

        #endregion

        public HomePageObject(IWebDriver driver)
           : base(driver)
        {
        }

        #region methods

        public void NavigateToHomePage()
        {
            NavegateTo(homeURL);
        }

        public bool IsOnHomePage(string url)
        {
            return homeURL == url;
        }

        public bool IsHomeButtonActive()
        {
            return GetDriver.FindElement(By.CssSelector("li:nth-child(1)")).GetAttribute("class").Contains("active");
        }

        #endregion
    }
}
