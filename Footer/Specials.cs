﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject2.PageObject.Footer
{
    public class Specials : FooterMain
    {
        public Specials(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
