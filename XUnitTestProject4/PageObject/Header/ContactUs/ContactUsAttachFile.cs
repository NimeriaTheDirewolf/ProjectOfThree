using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace XUnitTestProject4.PageObject
{
    public class ContactUsAttachFile : Header
    {
        public ContactUsAttachFile(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}