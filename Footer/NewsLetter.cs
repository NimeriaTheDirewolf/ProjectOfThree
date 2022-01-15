using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject2.PageObject.Footer
{
    public class NewsLetter : FooterMain
    {
        public NewsLetter (IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
