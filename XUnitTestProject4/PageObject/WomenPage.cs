using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    public class WomenPage : HeaderFooter
    {
        public WomenPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
