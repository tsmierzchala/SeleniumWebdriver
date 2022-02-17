using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace SeleniumWebdriver.AA_Wstep
{
    public class SecondSeleniumTest
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.saucedemo.com/";
        }

        [Test]
        public void SearchForMyCompanyShouldReturnSomeResults()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            IList<IWebElement> cards = driver.FindElements(By.ClassName("inventory_item"));
            foreach (IWebElement card in cards) {
                IWebElement inventory_item_name = card.FindElement(By.ClassName("inventory_item_name"));
                Console.WriteLine(inventory_item_name.Text);
            }
        }

        [TearDown]
        public void TearDown()
        {
        }
    }

}
