using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    public class CasualDressesPage : Header
    {
        public CasualDressesPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
