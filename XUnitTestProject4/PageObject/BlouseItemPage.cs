﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    class BlouseItemPage
    {
        IWebDriver _driver;

        public BlouseItemPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
