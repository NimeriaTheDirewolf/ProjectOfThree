using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    class SearchResultPage : HeaderFooter
    {
        public SearchResultPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}

