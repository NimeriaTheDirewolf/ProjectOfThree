using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace XUnitTestProject4.PageObject
{
    // Инна.
    public class ForgotPassword:Header
    {
        public ForgotPassword(IWebDriver driver)
        {
            _driver = driver;
        }
        private readonly By _homeHouseBtn = By.XPath("//div[@id='columns']/div/a/i");
        private readonly By _eMailField = By.Id("email");
        private readonly By _retrievePasswordBtn = By.XPath("//span[contains(.,'Retrieve Password')]");

        public HomePage clickHomeHouseBtn()
        {
            _driver.FindElement(_homeHouseBtn).Click();
            return new HomePage(_driver);
        }
        public ForgotPassword inputEmail(string eMail)
        {
            _driver.FindElement(_eMailField).SendKeys(eMail);
            return this;
        }

        public ForgotPassword RetrieveClick()
        {
            _driver.FindElement(_retrievePasswordBtn).Click();
            return this;
        }
        
    }
}