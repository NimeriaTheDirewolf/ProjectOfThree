using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace XUnitTestProject4.PageObject.Account
{  //Инна
    class MyWishListsPage:HeaderFooter
    {
        public MyWishListsPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private readonly By _homeHouseBtn = By.XPath("//div[@id='columns']/div/a/i");
        private readonly By _nameField = By.XPath("//span[contains(.,' Home')]");
        private readonly By _backToYourAccount = By.XPath("//span[contains(.,' Back to your account.')]");
        private readonly By _saveBtn = By.XPath("//span[contains(.,'Save')]");
        private readonly By _homeBtn = By.XPath("//span[contains(.,' Home')]");
        
        public HomePage ckickHomeHouseBtn()
        {
            _driver.FindElement(_homeHouseBtn).Click();
            return new HomePage(_driver);
        }
        public MyWishListsPage inputWishListName(string wishListName)
        {
            _driver.FindElement(_nameField).SendKeys(wishListName);
            return this;
        }
        public AccountCreationPage clichBackToAccountBtn()
        {
            _driver.FindElement(_backToYourAccount).Click();
            return new AccountCreationPage(_driver);
        }
        public MyWishListsPage clickSaveBtn()
        {
            _driver.FindElement(_saveBtn).Click();
            return this;
        }
        public HomePage ckickHomeBtn()
        {
            _driver.FindElement(_homeBtn).Click();
            return new HomePage(_driver);
        }
       
    }
}