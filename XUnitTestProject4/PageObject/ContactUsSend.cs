using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace XUnitTestProject4.PageObject
{
    public class ContactUsSend : HeaderFooter
    {
        public ContactUsSend(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
