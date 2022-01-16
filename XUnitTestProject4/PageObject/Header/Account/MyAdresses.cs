using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace XUnitTestProject4.PageObject.Account
{  
    // Инна.
    
    class MyAddresses:Header
    {
        public MyAddresses(IWebDriver driver)
        {
            _driver = driver;
        }
        private readonly By _homeHouseBtn = By.XPath("//div[@id='columns']/div/a/i");
        private readonly By _myAccountElement = By.XPath("//span[contains(.,' Back to your account.')]");
        private readonly By _updateAddressBtn = By.XPath("//span[contains(.,'Update')]");
        private readonly By _addNewAddressBtn = By.XPath("//span[contains(.,'Add a new address')]");
        private readonly By _deleteBtn = By.XPath("//span[contains(.,'Delete')]");
        private readonly By _backYourAccountBtn = By.XPath("//span[contains(.,' Back to your account.')]");
        private readonly By _homeBtn = By.XPath("//span[contains(.,' Home')]");
        
        public HomePage clickHomeHouseBtn()
        {
            _driver.FindElement(_homeHouseBtn).Click();
            return new HomePage(_driver);
        }
        public AccountCreationPage clichMyAccount()
        {
            _driver.FindElement(_myAccountElement).Click();
            return new AccountCreationPage(_driver);
        }
        public YourAddresses clickUpdateBtn()
        {
            _driver.FindElement(_updateAddressBtn).Click();
            return new YourAddresses(_driver);
        }
        public YourAddresses clickAddNewAddress()
        {
            _driver.FindElement(_addNewAddressBtn).Click();
            return new YourAddresses(_driver);
        }
        public AccountCreationPage clichBackToAccountBtn()
        {
            _driver.FindElement(_backYourAccountBtn).Click();
            return new AccountCreationPage(_driver);
        }
        public HomePage clickHomeBtn()
        {
            _driver.FindElement(_homeBtn).Click();
            return new HomePage(_driver);
        }
       
    }
}