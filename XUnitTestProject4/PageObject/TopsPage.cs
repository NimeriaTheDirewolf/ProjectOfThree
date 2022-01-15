using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
     class TopsPage:HeaderFooter
    {
        public TopsPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
