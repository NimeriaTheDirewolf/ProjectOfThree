using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    public class SummerDressesPage : HeaderFooter
    {
        public SummerDressesPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
