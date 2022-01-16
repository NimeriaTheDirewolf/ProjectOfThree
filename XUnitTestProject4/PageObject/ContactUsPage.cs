using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    public class ContactUsPage : HeaderFooter
    {
        public ContactUsPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}

