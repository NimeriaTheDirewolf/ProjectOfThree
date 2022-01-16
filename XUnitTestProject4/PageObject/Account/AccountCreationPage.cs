using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace XUnitTestProject4.PageObject.Account
{   
    // Инна.
    class AccountCreationPage:HeaderFooter
    {
        public AccountCreationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _homeBtn = By.XPath("//div[@id='columns']/div/a/i");
        private readonly By _genderMr = By.XPath("//div[@id='uniform-id_gender1']/span/input");
        private readonly By _genderMrs = By.XPath("//div[2]/label/div/span/input");
        private readonly By _firstNameField = By.Name("customer_firstname");
        private readonly By _lastNameField = By.Name("customer_lastname");
        private readonly By _passwordField = By.Id("passwd");
        private readonly By _dayBirthBtn = By.Id("days");
        private readonly By _monthsBirthBtn = By.Id("months");
        private readonly By _yearBirthBtn = By.Id("years");
        private readonly By _sinhInNewsCheckBox = By.Id("newsletter");
        private readonly By _getOffersCheckBox = By.XPath("//div[8]/div/span/input");
        private readonly By _firstName2Field = By.Id("firstname");
        private readonly By _lastName2Field = By.Id("lastname");
        private readonly By _companyField = By.Id("company");
        private readonly By _addressStreetField = By.Id("address1");
        private readonly By _addressDetailedField = By.Id("address2");
        private readonly By _cityField = By.Id("city");
        private readonly By _stateBtn = By.Id("id_state");
        private readonly By _zipPostCodeField = By.XPath("//input[@id='postcode']");
        private readonly By _countryBtn = By.Id("id_country");
        private readonly By _additionalInfoField = By.Id("other");
        private readonly By _homePhoneField = By.Id("phone");
        private readonly By _mobilePhoneField = By.Id("phone_mobile");
        private readonly By _asinAliasAddressField = By.XPath("//input[@id='alias']");
        private readonly By _registerBtn = By.XPath("//input[@id='customer_lastname']");
        
        public HomePage clickHomeBtn()
        {
            _driver.FindElement(_homeBtn).Click();
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
        public AccountCreationPage inputFirstName(string firstName)
        {
            _driver.FindElement( _firstNameField).SendKeys(firstName);
            return this;
        }

        public AccountCreationPage inputLastNamee(string lastName)
        {
            _driver.FindElement(_lastNameField).SendKeys(lastName);
            return this;
        }

        public AccountCreationPage inputPassword(string password)
        {
            _driver.FindElement(_passwordField).SendKeys(password);
            return this;
        }
        public AccountCreationPage inputDayBirth(string day)
        {
            _driver.FindElement(_dayBirthBtn).Click();
            _driver.FindElement(_dayBirthBtn).SendKeys(day);
            _driver.FindElement(_dayBirthBtn).SendKeys(Keys.Enter);
            return this;
        }

        public AccountCreationPage inputMonthsBirth(string month)
        {
            _driver.FindElement(_monthsBirthBtn).Click();
            _driver.FindElement(_monthsBirthBtn).SendKeys(month);
            _driver.FindElement(_monthsBirthBtn).SendKeys(Keys.Enter);
            return this;
        }

        public AccountCreationPage inputYearBirth(string year)
        {
            _driver.FindElement(_yearBirthBtn).Click();
            _driver.FindElement(_yearBirthBtn).SendKeys(year);
            _driver.FindElement(_yearBirthBtn).SendKeys(Keys.Enter);
            return this;
        }

        public AccountCreationPage clickSingUpNewslettersCheckBox()
        {
            _driver.FindElement(_sinhInNewsCheckBox).Click();
            return this;
        }

        public AccountCreationPage clickRecieveSpecialOffers()
        {
            _driver.FindElement(_getOffersCheckBox).Click();
            return this;
        }

        public AccountCreationPage inputFirstName2 (string firstName)
        {
            _driver.FindElement(_firstName2Field).SendKeys(firstName);
            return this;
        }
        public AccountCreationPage inputLirstName2(string lastName)
        {
            _driver.FindElement(_lastName2Field).SendKeys(lastName);
            return this;
        }

        public AccountCreationPage inputCompany(string company)
        {
            _driver.FindElement(_companyField).SendKeys(company);
            return this;
        }

        public AccountCreationPage inputAddressStreet(string address1)
        {
            _driver.FindElement(_addressStreetField).SendKeys(address1);
            return this;
        }

        public AccountCreationPage inputAddressDetailes(string address2)
        {
            _driver.FindElement(_addressDetailedField).SendKeys(address2);
            return this;
        }
        public AccountCreationPage inputCity(string city)
        {
            _driver.FindElement(_cityField).SendKeys(city);
            return this;
        }

        public AccountCreationPage inputState(string state)
        {
            _driver.FindElement(_stateBtn).SendKeys(state);
            return this;
        }

        public AccountCreationPage inputZipPostCodeNumbers(string zipPostCode)
        {
            _driver.FindElement(_zipPostCodeField).SendKeys(zipPostCode);
            return this;
        }

        public AccountCreationPage inputCountry(string country)
        {
            _driver.FindElement(_countryBtn).SendKeys(country);
            return this;
        }

        public AccountCreationPage inputAdditionalInfo(string additionalInfo)
        {
            _driver.FindElement(_additionalInfoField).SendKeys(additionalInfo);
            return this;
        }

        public AccountCreationPage inputHomePhone(string homePhone)
        {
            _driver.FindElement(_homePhoneField).SendKeys(homePhone);
            return this;
        }
        public AccountCreationPage inpuMobilePhone(string mobilePhone)
        {
            _driver.FindElement(_mobilePhoneField).SendKeys(mobilePhone);
            return this;
        }
        public AccountCreationPage inputAliasAddress(string addressAlias)
        {
            _driver.FindElement(_asinAliasAddressField).SendKeys(addressAlias);
            return this;
        }

        public AccountCreationPage clickRegisterBtn()
        {
            _driver.FindElement(_registerBtn).Click();
            return this;
        }
       
    }
}