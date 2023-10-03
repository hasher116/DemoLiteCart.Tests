using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Net.WebRequestMethods;

namespace DemoLiteCart.Tests.Bases
{
    public class Base
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.Url = "https://www.saucedemo.com/";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown() 
        {
            driver.Quit();
        }
    }
}