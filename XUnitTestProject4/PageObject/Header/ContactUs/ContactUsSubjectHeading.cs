using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace XUnitTestProject4.PageObject 
{ 
    public class ContactUsSubjectHeading : Header
    {
        public ContactUsSubjectHeading(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
