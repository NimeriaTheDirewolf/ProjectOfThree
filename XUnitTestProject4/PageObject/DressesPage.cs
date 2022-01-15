using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    class DressesPage : HeaderFooter
    {
        public DressesPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
