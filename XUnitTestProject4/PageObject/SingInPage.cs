﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
    class SignInPage : HeaderFooter
    {
        public SignInPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}

