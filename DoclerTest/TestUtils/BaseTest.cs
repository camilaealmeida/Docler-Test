using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DoclerTest.Steps
{
    public class BaseTest
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static void CloseDriver()
        {
            driver.Close();
        }
    }
}