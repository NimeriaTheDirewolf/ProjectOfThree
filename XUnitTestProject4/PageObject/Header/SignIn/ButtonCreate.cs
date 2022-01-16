using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace  XUnitTestProject4.PageObject
{
    public class ButtonCreate : Header
    { //делала Катя
        public ButtonCreate(IWebDriver driver)
    {
        _driver = driver;
    }
    }
}