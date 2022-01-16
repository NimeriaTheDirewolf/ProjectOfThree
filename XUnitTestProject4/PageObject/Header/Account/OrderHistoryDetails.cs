using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace XUnitTestProject4.PageObject.Account
{  
    // Инна.
    
    class OrderHistoryDetails:Header
    {
        public OrderHistoryDetails(IWebDriver driver)
        {
            _driver = driver;
        }
        private readonly By _homeHouseBtn = By.XPath("//div[@id='columns']/div/a/i");
        private readonly By _backToYourAccount = By.XPath("//span[contains(.,' Back to your account.')]");
        private readonly By _homeBtn = By.XPath("//span[contains(.,' Home')]");
        
        public HomePage ckickHomeHouseBtn()
        {
            _driver.FindElement(_homeHouseBtn).Click();
            return new HomePage(_driver);
        }
        public AccountCreationPage clichBackToAccountBtn()
        {
            _driver.FindElement(_backToYourAccount).Click();
            return new AccountCreationPage(_driver);
        }
        public HomePage ckickHomeBtn()
        {
            _driver.FindElement(_homeBtn).Click();
            return new HomePage(_driver);
        }
       
    }
}