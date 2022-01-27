using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebdriver
{
    public class FirstSeleniumTest
    {
        IWebDriver driver;
        
        [SetUp]
        public void Setup()
        {
            // przygotuj sterownik przegl¹darki
        }

        [Test]
        public void SearchForMyCompanyShouldReturnSomeResults()
        {
            // odpal stronê bing.com i wyszukaj swoj¹ firmê w Google
            driver = new ChromeDriver();
            driver.Url = "https://www.bing.com";
            driver.FindElement(By.Name("q")).Click();
            driver.FindElement(By.Name("q")).SendKeys("MojaFirma");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            driver.Quit();
        }

        [TearDown]
        public void TearDown()
        {
            // zamknij przegl¹darkê
        }
    }
}