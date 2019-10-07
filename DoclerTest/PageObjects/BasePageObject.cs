using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DoclerTest.PageObjects
{
    public class BasePageObject
    {
        private readonly IWebDriver driver;

        #region elements

        public IWebElement DhLogo =>
            driver.FindElement(By.Id("dh_logo"));
        public IWebElement UITestingButton =>
            driver.FindElement(By.Id("site"));
        public IWebElement HomeButton =>
            driver.FindElement(By.Id("home"));
        public IWebElement FormButton =>
            driver.FindElement(By.Id("form"));
        public IWebElement ErrorButton =>
            driver.FindElement(By.Id("error"));
        public IWebElement HeadingText =>
            driver.FindElement(By.TagName("h1"));

        #endregion

        public BasePageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region methods

        public IWebDriver GetDriver
        {
            get
            {
                return driver;
            }
        }

        public string GetPageTitle
        {
            get
            {
                return driver.Title;
            }
        }

        public void QuitDriver()
        {
            driver.Quit();
        }

        public void ClickUITestingButton()
        {
            UITestingButton.Click();
        }

        public void ClickHomeButton()
        {
            HomeButton.Click();
        }

        public void ClickFormButton()
        {
            FormButton.Click();
        }

        public void ClickErrorButton()
        {
            ErrorButton.Click();
        }

        public void NavegateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        #endregion

    }
}
