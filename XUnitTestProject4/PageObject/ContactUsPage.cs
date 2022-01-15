using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    class ContactUsPage : Header
    {
        public ContactUsPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}

