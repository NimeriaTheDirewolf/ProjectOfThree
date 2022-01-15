using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject.Footer
{
    public class Women: FooterMain
    {
        public Women(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
