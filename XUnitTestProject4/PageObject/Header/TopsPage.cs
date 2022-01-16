using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    public class TopsPage: Header
    {
        public TopsPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
