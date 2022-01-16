using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    public class BlouseItemPage
    {
        IWebDriver _driver;

        public BlouseItemPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
