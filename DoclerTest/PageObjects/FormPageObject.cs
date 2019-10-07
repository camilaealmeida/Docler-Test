using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DoclerTest.PageObjects
{
    public class FormPageObject : BasePageObject
    {
        private string formURL = "http://uitest.duodecadits.com/form.html";

        #region elements

        public IWebElement HelloInputText =>
            GetDriver.FindElement(By.Id("hello-input"));
        public IWebElement GoSubmitButton =>
            GetDriver.FindElement(By.Id("hello-submit"));
        public IWebElement HelloResultText =>
            GetDriver.FindElement(By.Id("hello-text"));

        #endregion

        public FormPageObject(IWebDriver driver)
            : base(driver)
        {
        }

        #region methods

        public void SendKeysToInputText(string text)
        {
            HelloInputText.Clear();
            HelloInputText.SendKeys(text);
        }

        public void ClickGoSubmitButton()
        {
            GoSubmitButton.Click();
        }

        public void NavigateToFormPage()
        {
            NavegateTo(formURL);
        }

        public bool IsOnFormPage(string url)
        {
            return formURL == url;
        }

        public bool IsFormButtonActive()
        {
            return GetDriver.FindElement(By.CssSelector("li:nth-child(2)"))
                .GetAttribute("class").Contains("active");
        }

        #endregion
    }
}
