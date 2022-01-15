using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace XUnitTestProject4.PageObject
{
      class AccountCreationPage
    {
        protected IWebDriver _driver;
        
        private By _returnToHomeBtn = By.XPath("//a/i");
        private By _genderMr = By.Name("id_gender");
        private By _genderMrs = By.Name("id_gender2");
        private By _firstNameField = By.Id("customer_firstname");
        private By _lastNameField = By.Id("customer_lastname");
        private By _eMailField = By.Id("email");
        private By _passwordField = By.XPath("//input[@id='passwd']");
        private By _dayBirthDropDown = By.XPath("//select[@id='days']");
        private By _monthBirthDropDown = By.Id("months");
        private By _yearBirthDropDown = By.Id("years");
        private By _singUpNewsletterCheckBox = By.XPath("//div[7]/label");
        private By _specialOfferCheckBox = By.XPath("//div[8]/label");
        private By _firstNameField2 = By.Name("firstname");
        private By _lastNameField2 = By.Name("lastname");
        private By _companyField = By.Id("company");
        private By _addressField1 = By.Id("address1");
        private By _addressField2 = By.Id("address2");
        private By _cityField = By.Id("city");
        private By _stateField = By.Id("state");
        private By _zipPostalCodeField = By.Id("postcode");
        private By _countryField = By.Id("id_country");
        private By _additionalInformationField = By.Id("other");
        private By _homePhoneField = By.Id("phone");
        private By _mobilePhoneField = By.Id("phone_mobile");
        private By _eMail2 = By.Id("alias");
        private By _registerBtn = By.XPath("account-creation_form");
        
        public HeaderFooter clickReturnToHomeElem()
        {
            _driver.FindElement(_returnToHomeBtn).Click();
            return new HomePage(_driver);
        }
        public AccountCreationPage clickGenderMr()
        {
            _driver.FindElement(_genderMr).Click();
            return this;
        }
        public AccountCreationPage clickGenderMrs()
        {
            _driver.FindElement(_genderMrs).Click();
            return this;
        }
        public AccountCreationPage inputFirstName()
        {
            _driver.FindElement(_firstNameField).SendKeys("Eduard");
            return this;
        }
        public AccountCreationPage inputLastName()
        {
            _driver.FindElement(_lastNameField).SendKeys("Edikovich");
            return this;
        }
        public AccountCreationPage inputEmailAdress()
        {
            _driver.FindElement(_eMailField).SendKeys("testEduardo@test.com");
            return this;
        }
        public AccountCreationPage inputPassvord()
        {
            _driver.FindElement(_passwordField).SendKeys("131423hj");
            return this;
        }
        public AccountCreationPage clickDayBirthElement()
        {
            _driver.FindElement(_dayBirthDropDown).Click();
            return this;
        }
        public AccountCreationPage clickMonthsBirthElement()
        {
            _driver.FindElement(_monthBirthDropDown).Click();
            return this;
        }
        public AccountCreationPage clickYearsBirthElement()
        {
            _driver.FindElement(_yearBirthDropDown).Click();
            return this;
        }
        public AccountCreationPage clickSingUp()
        {
            _driver.FindElement(_singUpNewsletterCheckBox).Click();
            return this;
        }
        public AccountCreationPage clickRecieveSpesialOffer()
        {
            _driver.FindElement(_specialOfferCheckBox).Click();
            return this;
        }
        public AccountCreationPage inputFirstName2()
        {
            _driver.FindElement(_firstNameField2).SendKeys("Edik");
            return this;
        }
        public AccountCreationPage inputLastName2()
        {
            _driver.FindElement(_lastNameField2).SendKeys("Zmikh");
            return this;
        }
        public AccountCreationPage inputCampanyName()
        {
            _driver.FindElement(_companyField).SendKeys("AbobaInterprize");
            return this;
        }
        public AccountCreationPage inputAddressField1()
        {
            _driver.FindElement(_addressField1).SendKeys("Petrikovka");
            return this;
        }
        public AccountCreationPage inputAddressField2()
        {
            _driver.FindElement(_addressField2).SendKeys("Appartament Luxury 3");
            return this;
        }
        public AccountCreationPage inputCityName()
        {
            _driver.FindElement(_cityField).SendKeys("Denever");
            return this;
        }
        public AccountCreationPage clickStateDropDownBtn()
        {
            _driver.FindElement(_stateField).Click();
            return this;
        }
        public AccountCreationPage inputZipCode()
        {
            _driver.FindElement(_zipPostalCodeField).SendKeys("11111");
            return this;
        }
        public AccountCreationPage clickCountryDropDownBtn()
        {
            _driver.FindElement(_countryField).Click();
            return this;
        }
        public AccountCreationPage inputAdditionalInformation()
        {
            _driver.FindElement(_additionalInformationField).SendKeys("More Tests");
            return this;
        }
        public AccountCreationPage inputHomePhone()
        {
            _driver.FindElement(_homePhoneField).SendKeys("32435465");
            return this;
        }
        public AccountCreationPage inputMobilePhone()
        {
            _driver.FindElement(_mobilePhoneField).SendKeys("+380931111113");
            return this;
        }
        public AccountCreationPage inputEmailAddress()
        {
            _driver.FindElement(_eMail2).SendKeys("testresttest@mail.ru");
            return this;
        }
        public AccountCreationPage clickRegisterBtn()
        {
            _driver.FindElement(_registerBtn).Click();
            return this;
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        




    }
}