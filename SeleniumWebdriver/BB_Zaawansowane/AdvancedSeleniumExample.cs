using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebdriver.BB_Zaawansowane
{
    public class AdvancedSeleniumExample
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }


        [Test]
        public void TestCodeInIt()
        {
            driver.Url = "https://testpages.herokuapp.com/styled/basic-ajax-test.html";
            IWebElement codeInItButton = driver.FindElement(By.Name("submitbutton"));
            codeInItButton.Click();

            IWebElement valueId = driver.FindElement(By.Id("_valueid"));
            StringAssert.AreEqualIgnoringCase(valueId.Text, "1");
        }

        [Test]
        public void TestDynamicTable()
        {
            driver.Url = "https://testpages.herokuapp.com/styled/tag/dynamic-table.html";
            IWebElement tableData = driver.FindElement(By.XPath("//section"));
            tableData.Click();

            IWebElement textArea = driver.FindElement(By.Id("jsondata"));
            textArea.Click();
            textArea.Clear();

            string table = "[{'name' : 'Bob', 'age' : 20}, {'name': 'George', 'age' : 42}]"
            textArea.SendKeys(table);

        }
    }
}
