using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumUITest
{
    [TestClass]
    public class LoginWebShop
    {
        IWebDriver driver;
        [TestInitialize]
        public void Init()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.Manage().Window.FullScreen();
        }
        [TestMethod]
        public void Login()
        {
            try
            {

                string title = driver.Title;
                Assert.AreEqual(title, "Demo Web Shop");
                driver.FindElement(By.ClassName("ico-login")).Click();
                string loginTitle = driver.Title;
                Assert.AreEqual(loginTitle, "Demo Web Shop. Login");

                driver.FindElement(By.Id("Email")).SendKeys("Priyankak272013@gmail.com");
                driver.FindElement(By.Id("Password")).SendKeys("Pr12345");
                driver.FindElement(By.ClassName("login-button")).Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
