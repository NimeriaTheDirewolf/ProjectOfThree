﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    class CasualDressesPage : HeaderFooter
    {
        public CasualDressesPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
