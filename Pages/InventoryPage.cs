using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLiteCart.Tests.Pages
{
    internal class InventoryPage 
    {
        private IWebDriver driver;
        public InventoryPage (IWebDriver driver)
        {
            this.driver = driver;
        }
        private By locatorProducts = By.XPath("//span[@class = 'title']");

        public string CheckLocator()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            return wait.Until(ExpectedConditions.ElementIsVisible(locatorProducts)).Text;
        }
    }
}
