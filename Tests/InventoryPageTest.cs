using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLiteCart.Tests.Bases;
using DemoLiteCart.Tests.Pages;

namespace DemoLiteCart.Tests.Tests
{
    [TestFixture]
    internal class InventoryPageTest : Base
    {
        [TestCase ("performance_glitch_user", "secret_sauce")]
        public void CheckProduct_WhenUsedGlitchUser(string username, string password)
        {
            string expectedText = "Products";

            MainPage mainPage = new MainPage(driver);
            mainPage.AddLoginAndPassword(username, password)
                .CheckLogin();

            InventoryPage inventoryPage = new InventoryPage(driver);
            inventoryPage.CheckLocator();

            Assert.That(inventoryPage.CheckLocator(), Is.EqualTo(expectedText));
        }
    }
}
