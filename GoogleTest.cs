using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumNUnitProject
{
    public class GoogleTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void GoogleSearch_ShouldReturnResults()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            var searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("Test Automation");
            searchBox.Submit();

            Assert.That(driver.Title, Does.Contain("Search"));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
