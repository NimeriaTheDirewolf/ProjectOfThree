﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    public class TshirtPage : HeaderFooter
    {
        public TshirtPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
