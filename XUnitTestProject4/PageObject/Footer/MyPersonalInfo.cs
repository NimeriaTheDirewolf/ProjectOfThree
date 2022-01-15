using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace XUnitTestProject4.PageObject
{
    public class MyPersonalInfo : FooterMain
    {
        public MyPersonalInfo(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
