using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace XUnitTestProject4.PageObject
{
    public class MyCreditSlips : FooterMain
    {
        public MyCreditSlips(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
