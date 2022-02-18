using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebdriver.PageObjectPattern.pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By userNameLocator => By.XPath("//a[contains(@href,'@')]");
        private IWebElement userNameInput => driver.FindElement(userNameLocator);
        //private string username = userNameInput.Text;

        public string getUserName()
        {
            return userNameInput.Text;
        }

    }
}
