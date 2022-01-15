using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
     class ShoppingCardPage: Header
    {
        public ShoppingCardPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
