using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
  public class SignInPage : HeaderFooter
    {
       protected IWebDriver _driver;

        private By _clickSignIn = By.LinkText("Sign in");
        private By _fieldEmailRegister = By.Id("email_create");
        private By _clickCreate = By.CssSelector("#SubmitCreate > span");
        private By _fieldEmailLogin = By.Id("email");
        private By _fieldPasword = By.Id("passwd");
        private  By _clickButtonSignIn = By.CssSelector("#SubmitLogin > span");
        private By _clickButtonGorgot = By.LinkText("Forgot your password?");
        private IWebDriver driver;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public HomePage clickSignIn()
        {
            _driver.FindElement(_clickSignIn).Click();
            return new HomePage(_driver);
        }
        public SignInPage writeEmailRegister()
        {
            _driver.FindElement(_fieldEmailRegister).SendKeys("katrin.shugay@gmail.com");
            _driver.FindElement(_fieldEmailRegister).SendKeys(Keys.Enter);
            return new SignInPage(_driver);
        }
        public SignInPage clickCreate()
        {
            _driver.FindElement(_clickCreate).Click();
            return new SignInPage(_driver);
        }
        public SignInPage writeEmailLogin()
        {
            _driver.FindElement(_fieldEmailLogin).SendKeys("katrin.shugay@gmail.com");
            _driver.FindElement(_fieldEmailLogin).SendKeys(Keys.Enter);
            return this;
        }
        public SignInPage writePasword()
        {
            _driver.FindElement(_fieldPasword).SendKeys("pasword");
            _driver.FindElement(_fieldPasword).SendKeys(Keys.Enter);
            return new SignInPage(_driver);
        }
        public SignInPage clickButtonSignIn()
        {
            _driver.FindElement(_clickButtonSignIn).Click();
            return new SignInPage(_driver);
        }
        public SignInPage clickButtonForgot()
        {
            _driver.FindElement(_clickButtonGorgot).Click();
            return new SignInPage(_driver);
        }
    }
}

