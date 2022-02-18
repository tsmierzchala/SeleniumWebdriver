using Faker;
using NUnit.Compatibility;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebdriver.PageObjectPattern.pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebdriver.PageObjectPattern.tests
{
    public class RegisterUserTestcs
    {
        private IWebDriver driver;
        private string username;
        private string email;
        private string password;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void TestUserRegistration()
        {
            driver.Url = "https://react-redux.realworld.io/#/register";

            var timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
            username = Faker.Name.FullName(NameFormats.WithPrefix);
            email = Faker.Internet.Email(username);
            password = "testowy1234";

            RegisterPage registerPage = new RegisterPage(driver);
            registerPage.CreateUser(username, email, password);
            HomePage homePage = new HomePage(driver);
            StringAssert.AreEqualIgnoringCase(username, homePage.getUserName());
        }

        [Test]
        public void TestSettings()
        {
            driver.Url = "https://react-redux.realworld.io/#/login";
        }
    }
}
