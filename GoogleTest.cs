using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumNUnitProject
{
    public class GoogleTests
    {
        private ChromeDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void GoogleSearch_ShouldReturnResults()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.FindElement(By.Name("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Name("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Name("login-button")).Submit();

            Assert.That(driver.Title, Does.Contain("Swag Labs"));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
