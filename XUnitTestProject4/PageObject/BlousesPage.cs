﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    class BlousesPage : Header
    {
        public BlousesPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}