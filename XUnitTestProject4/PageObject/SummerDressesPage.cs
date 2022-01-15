using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    class SummerDressesPage : Header
    {
        public SummerDressesPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
