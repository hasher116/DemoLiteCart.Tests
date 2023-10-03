using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLiteCart.Tests.Pages;
using DemoLiteCart.Tests.Bases;

namespace DemoLiteCart.Tests.Tests
{
    [TestFixture]
    internal class MainPageTest : Base
    {
        [TestCase("standard_user", "secret_sauce")]
        [TestCase("problem_user", "secret_sauce")]
        [TestCase("performance_glitch_user", "secret_sauce")]

        public void ShouldBeShownTrueForNewURL_WhenAddLoginAndPassword(string login, string password)
        {
            string expectedURL = "https://www.saucedemo.com/inventory.html";

            MainPage test = new MainPage(driver);
            test.AddLoginAndPassword(login, password)
                .CheckLogin();
            string currentURL = driver.Url;

            Assert.That(currentURL, Is.EqualTo(expectedURL));
        }

        [TestCase("vasya", "123")]
        [TestCase("andrew", "qwerty")]
        [TestCase("asdas", "gsfgfsd")]
        public void ShouldBeShownTrue_WhenAddWrongLoginAndPassword(string login, string password)
        {
            string expectedError = "Epic sadface: Username and password do not match any user in this service";

            MainPage test = new MainPage(driver);
            string currentError = test.AddLoginAndPassword(login, password)
                .CheckLogin()
                .CheckError();
            Assert.That(currentError, Is.EqualTo(expectedError));
        }

        [TestCase("locked_out_user", "secret_sauce")]
        public void ShouldBeShownTrue_WhenAddBlockedLoginAndPassword(string login, string password)
        {
            string expectedError = "Epic sadface: Sorry, this user has been locked out.";

            MainPage test = new MainPage(driver);
            string currentError = test.AddLoginAndPassword(login, password)
                .CheckLogin()
                .CheckError();
            Assert.That(currentError, Is.EqualTo(expectedError));
        }

        [TestCase("performance_glitch_user", "secret_sauce")]
        public void ShouldBeShownFalse_WhenAddGlitchLoginAndPassword(string login, string password)
        {
            string expectedURL = "https://www.saucedemo.com/inventory.html";

            MainPage test = new MainPage(driver);
            test.AddLoginAndPassword(login, password)
                .CheckLogin();

            string currentURL = driver.Url;
            Assert.That(currentURL, Is.EqualTo(expectedURL));
        }
    }
}
