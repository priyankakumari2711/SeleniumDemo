using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumUITest
{
    [TestClass]
    public class RegisterWebShop
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
        public void Registration()
        {
            try
            {

                string title = driver.Title;
                Assert.AreEqual(title, "Demo Web Shop");
                driver.FindElement(By.ClassName("ico-register")).Click();
                string registerTitle = driver.Title;
                Assert.AreEqual(registerTitle, "Demo Web Shop. Register");

                driver.FindElement(By.Id("gender-male")).Click();
                driver.FindElement(By.Id("FirstName")).SendKeys("Priyanka");
                driver.FindElement(By.Id("LastName")).SendKeys("kumari");
                driver.FindElement(By.Id("Email")).SendKeys("Priyankasharma2711ps@gmail.com");
                driver.FindElement(By.Id("Password")).SendKeys("Pr12345");
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Pr12345");
                driver.FindElement(By.Id("register-button")).Click();

                string message = driver.FindElement(By.ClassName("result")).Text;
                Assert.AreEqual(message, "Your registration completed");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}