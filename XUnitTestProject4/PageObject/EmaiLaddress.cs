using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace XUnitTestProject4.PageObject
{
    public public class EmaiLaddress : HeaderFooter
    {
        public EmaiLaddress(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
