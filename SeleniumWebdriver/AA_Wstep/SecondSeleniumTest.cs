using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;

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

            //List<double> prices = new List<double>();
            Dictionary<string, double> results = new Dictionary<string, double>();

            IList<IWebElement> cards = driver.FindElements(By.ClassName("inventory_item"));
            foreach (IWebElement card in cards) {
                IWebElement inventory_item_name = card.FindElement(By.ClassName("inventory_item_name"));
                string title = inventory_item_name.Text;
                //Console.WriteLine(title);

                IWebElement inventory_item_price = card.FindElement(By.ClassName("inventory_item_price"));
                string new_price = inventory_item_price.Text[1..].Replace('.', ',');
                double price = double.Parse(new_price);
                //prices.Add(price);

                results.Add(title, price);
            }
            //prices.Sort();
            //foreach(double price in prices) {
            //    Console.WriteLine(price);
            //}

            var ordered = results.OrderBy(value => value.Value);

            foreach (KeyValuePair<string, double> entry in ordered) { 
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }

}
