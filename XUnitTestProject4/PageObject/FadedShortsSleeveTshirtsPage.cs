﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    class FadedShortSleeveTshirts : HeaderFooter
    {
        public FadedShortSleeveTshirts(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
