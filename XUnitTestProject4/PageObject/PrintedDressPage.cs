﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    class PrintedChiffonDressPage
    {
        IWebDriver _driver;

        public PrintedChiffonDressPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}