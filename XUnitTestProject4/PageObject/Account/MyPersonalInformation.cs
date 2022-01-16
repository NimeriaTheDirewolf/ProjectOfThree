using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace XUnitTestProject4.PageObject.Account
{     
    // Инна.
      class MyPersonalInformation:HeaderFooter
    {
        public MyPersonalInformation(IWebDriver driver)
        {
            _driver = driver;
        }
        
        
    }
}