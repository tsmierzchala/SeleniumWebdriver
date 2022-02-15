using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebdriver.AA_Wstep
{
    public class FirstSeleniumTest
    {
        IWebDriver driver;
        
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.bing.com";
        }

        [Test]
        public void SearchForMyCompanyShouldReturnSomeResults()
        {
            driver.FindElement(By.Name("q")).Click();
            driver.FindElement(By.Name("q")).SendKeys("MojaFirma");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}