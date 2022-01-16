using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    public class PrintedSummerDressPage
    {
        IWebDriver _driver;

        public PrintedSummerDressPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
