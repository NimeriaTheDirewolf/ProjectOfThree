using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    public class BlousesPage : HeaderFooter
    {
        public BlousesPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}