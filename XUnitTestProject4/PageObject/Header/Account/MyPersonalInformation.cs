using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace XUnitTestProject4.PageObject.Account
{     
    // Инна.
      class MyPersonalInformation:Header
    {
        public MyPersonalInformation(IWebDriver driver)
        {
            _driver = driver;
        }
        private readonly By _homeHouseBtn = By.XPath("//div[@id='columns']/div/a/i");
        private readonly By _genderMr = By.Id("id_gender1");
        private readonly By _genderMrs = By.Id("id_gender2");
        private readonly By _firstNameField = By.Id("customer_firstname");
        private readonly By _lastNameField = By.Id("customer_lastname");
        private readonly By _eMailField = By.Id("email");
        private readonly By _dayBirthBtn = By.Id("days");
        private readonly By _monthsBirthBtn = By.Id("months");
        private readonly By _yearBirthBtn = By.Id("years");
        private readonly By _currentPassword = By.Id("old-passwd");
        private readonly By _newPassword = By.Id("passwd");
        private readonly By _confirmationField = By.Id("confirmation");
        private readonly By _singUpNewsCheckBox = By.Id("newsletter");
        private readonly By _specialOffersCheckBox = By.Name("optin");
        private readonly By _saveBtn = By.XPath("//span[contains(.,'Save')]");
        private readonly By _backToYourAccount = By.XPath("//li/a/span");
        private readonly By _homeBtn = By.XPath("//li[2]/a/span/i");
        
        public HomePage ckickHomeHouseBtn()
        {
            _driver.FindElement(_homeHouseBtn).Click();
            return new HomePage(_driver);
        }
        public MyPersonalInformation clickGenderMr()
        {
            _driver.FindElement(_genderMr).Click();
            return this;
        }
        public MyPersonalInformation clickGenderMrs()
        {
            _driver.FindElement(_genderMrs).Click();
            return this;
        }
        public MyPersonalInformation inputFirstName(string firstName)
        {
            _driver.FindElement( _firstNameField).SendKeys(firstName);
            return this;
        }

        public MyPersonalInformation inputLastNamee(string lastName)
        {
            _driver.FindElement(_lastNameField).SendKeys(lastName);
            return this;
        }
        public MyPersonalInformation inputEmail(string eMail)
        {
            _driver.FindElement(_eMailField).SendKeys(eMail);
            return this;
        }
        public MyPersonalInformation inputDayBirth(string day)
        {
            _driver.FindElement(_dayBirthBtn).Click();
            _driver.FindElement(_dayBirthBtn).SendKeys(day);
            _driver.FindElement(_dayBirthBtn).SendKeys(Keys.Enter);
            return this;
        }

        public MyPersonalInformation inputMonthsBirth(string month)
        {
            _driver.FindElement(_monthsBirthBtn).Click();
            _driver.FindElement(_monthsBirthBtn).SendKeys(month);
            _driver.FindElement(_monthsBirthBtn).SendKeys(Keys.Enter);
            return this;
        }

        public MyPersonalInformation inputYearBirth(string year)
        {
            _driver.FindElement(_yearBirthBtn).Click();
            _driver.FindElement(_yearBirthBtn).SendKeys(year);
            _driver.FindElement(_yearBirthBtn).SendKeys(Keys.Enter);
            return this;
        }
        public MyPersonalInformation inputCurrentPasswrd(string currentPassword)
        {
            _driver.FindElement(_currentPassword).SendKeys(currentPassword);
            return this;
        }

        public MyPersonalInformation inputNewPasswrd(string newPassword)
        {
            _driver.FindElement(_newPassword).SendKeys(newPassword);
            return this;
        }
        public MyPersonalInformation inputConfermNewPassword(string confirmPassword)
        {
            _driver.FindElement(_confirmationField).SendKeys(confirmPassword);
            return this;
        }
        public MyPersonalInformation clickSingUpNewslettersCheckBox()
        {
            _driver.FindElement(_singUpNewsCheckBox).Click();
            return this;
        }

        public MyPersonalInformation clickRecieveSpecialOffers()
        {
            _driver.FindElement(_specialOffersCheckBox).Click();
            return this;
        }
        public MyPersonalInformation clickSaveBtn()
        {
            _driver.FindElement(_saveBtn).Click();
            return this;
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