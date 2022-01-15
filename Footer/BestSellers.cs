using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject2.PageObject.Footer
{
    public class BestSellers : FooterMain
    {
        public BestSellers(IWebDriver driver)
        {
            _driver = driver;   
        }
    }
}
