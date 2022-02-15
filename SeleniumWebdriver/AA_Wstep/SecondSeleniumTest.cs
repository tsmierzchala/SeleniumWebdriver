using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.saucedemo.com/";
        }

        [Test]
        public void SearchForMyCompanyShouldReturnSomeResults()
        {
            IWebElement usernameInput = driver.FindElement(By.Id("user-name"));
            IWebElement passwordInput = driver.FindElement(By.Id("password"));
            IWebElement loginButton = driver.FindElement(By.Id("login-button"));

            usernameInput.Click();
            usernameInput.SendKeys("standard_user");
            passwordInput.Click();
            passwordInput.SendKeys("secret_sauce");
            loginButton.Click();

            // zadanie 3
            IList<IWebElement> productNames = driver.FindElements(By.CssSelector(".inventory_item_name"));
            foreach (var product in productNames)
            {
                Console.WriteLine(product.Text);
            }

            // zadanie 4
            IWebElement sortDropdownElement = driver.FindElement(By.XPath("//*[@data-test='product_sort_container']"));
            var selectSortProducts = new SelectElement(sortDropdownElement);
            selectSortProducts.SelectByValue("hilo");

            // zadanie 6
            productNames = driver.FindElements(By.CssSelector(".inventory_item_name"));
            Assert.Multiple(() =>
            {
                Assert.That(productNames[0].Text, Is.EqualTo("Sauce Labs Fleece Jacket"));
                Assert.That(productNames[1].Text, Is.EqualTo("Sauce Labs Backpack"));
            });
            
        }
            

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }

}
