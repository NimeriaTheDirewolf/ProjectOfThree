using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    public class SearchResultPage : Header
    {
        public SearchResultPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}

