using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace XUnitTestProject4.PageObject.Account
{ 
    // Инна.
    public class YourAddresses : Header
    {
        public YourAddresses(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}