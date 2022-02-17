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

            List<double> price = new List<double>();

            IList<IWebElement> cards = driver.FindElements(By.ClassName("inventory_item"));
            foreach (IWebElement card in cards) {
                IWebElement inventory_item_name = card.FindElement(By.ClassName("inventory_item_name"));
                Console.WriteLine(inventory_item_name.Text);

                IWebElement inventory_item_price = card.FindElement(By.ClassName("inventory_item_price"));
                var new_price = inventory_item_price.Text[1..];
                price.Add(double.Parse(new_price.Replace('.', ',')));
            }
            price.Sort();
            foreach(double inventory_item in price) {
                Console.WriteLine(inventory_item);
            }
        }

        [TearDown]
        public void TearDown()
        {
        }
    }

}
