﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using DemoLiteCart.Tests.Bases;
using OpenQA.Selenium.DevTools.V112.Page;

namespace DemoLiteCart.Tests.Pages
{
    internal class MainPage
    {
        private IWebDriver driver;
        private By locatorLoginField = By.Id("user-name");
        private By locatorPasswordField = By.Id("password");
        private By locatorButtonLogin = By.Id("login-button");
        private By locatorErrorMessage = By.XPath("//div[@class = 'error-message-container error']");

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public MainPage AddLoginAndPassword(string login, string password)
        {
            driver.FindElement(locatorLoginField).SendKeys(login);
            driver.FindElement(locatorPasswordField).SendKeys(password);
            return this;
        }
        
        public MainPage CheckLogin()
        {
            driver.FindElement(locatorButtonLogin).Click();
            return this;
        }

        public string CheckError()
        {
            return driver.FindElement(locatorErrorMessage).Text;
        }
    }
}