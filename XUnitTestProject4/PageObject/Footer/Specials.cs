using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    public class Specials : FooterMain
    {
        public Specials(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
