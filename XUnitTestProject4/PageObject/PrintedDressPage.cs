using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    class PrintedDressPage
    {
        IWebDriver _driver;

        public PrintedDressPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
