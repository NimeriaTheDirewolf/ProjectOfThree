using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace XUnitTestProject4.PageObject
{
    public class NewProducts : FooterMain
    {
        public NewProducts(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
