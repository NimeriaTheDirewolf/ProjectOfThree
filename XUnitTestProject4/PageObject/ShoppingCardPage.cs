﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
     class ShoppingCardPage: HeaderFooter
    {
        public ShoppingCardPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
