using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
     class WomenPage : Header
    {
        public WomenPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
