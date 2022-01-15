using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    public class Twitter : FooterMain
    {
        public Twitter(IWebDriver driver)
        {
            _driver = driver;   
        }
    }
}
