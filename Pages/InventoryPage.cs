using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoLiteCart.Tests.Pages
{
    public class InventoryPage 
    {
        private IWebDriver driver;
        private By locatorProducts = By.XPath("//span[@class = 'title']");

        public InventoryPage (IWebDriver driver)
        {
            this.driver = driver;
        }

        public string CheckLocator()
        {
            return driver.FindElement(locatorProducts).Text;
            // var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            // return wait.Until(x => x.FindElement(locatorProducts).Text);
        }
    }
}
