using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace XUnitTestProject4.PageObject
{
    class HomePage : HeaderFooter
    {
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        private By _clickPopularElement = By.XPath("//a[contains(text(),'Popular')]");
        private By _clickBestSellersElement = By.XPath("//div[2]/div/ul/li[2]/a");
        private By _fadedShrtSlvTshirtElem = By.XPath("//div[2]/div/ul/li[2]/a");

        public HomePage clickPopularElement()
        {
            _driver.FindElement(_clickPopularElement).Click();
            return this;
        }
        public HomePage clickBestSellersElement()
        {
            _driver.FindElement(_clickBestSellersElement).Click();
            return this;
        }
        public HomePage hoverFadedShortSleevTshirt()
        {
            _driver.FindElement(_fadedShrtSlvTshirtElem).Click();
            return this;
        }
    }
}