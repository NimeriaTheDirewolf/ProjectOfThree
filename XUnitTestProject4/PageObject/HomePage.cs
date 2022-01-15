using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    class HomePage: Header
    {


        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}