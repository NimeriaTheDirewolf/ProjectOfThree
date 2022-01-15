using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    class EveningDressesPage : Header
    {
        public EveningDressesPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
