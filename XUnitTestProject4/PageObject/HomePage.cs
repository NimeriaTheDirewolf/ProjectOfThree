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
        private By _clickButtonShopNow = By.CssSelector(".homeslider-container:nth-child(2) .btn");
        private By _clickNext = By.XPath("//a[contains(text(),'Next')]");
        private By _clickPrev = By.XPath("//a[contains(text(),'Prev')]");
        private By _clickBanner = By.CssSelector("#htmlcontent_top .htmlcontent-item-1 .item-img");
        private By _clickBanner2 = By.CssSelector(".htmlcontent-item-3 .item-img");
        private By _clickBanner3 = By.CssSelector("#htmlcontent_home .htmlcontent-item-1 .item-img");
        private By _clickBanner4 = By.CssSelector(".htmlcontent-item-5 .item-img");
        private By _clickBanner5 = By.CssSelector("htmlcontent-item-4 .item-img");
        private By _clickBanner6 = By.CssSelector("#htmlcontent_home .htmlcontent-item-2 .item-img");
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
        public HomePage buttonShopNow()
        {
            _driver.FindElement(_clickButtonShopNow).Click();
            return new HomePage(_driver);
        }

        public HomePage buttonNext(By element)
        {
            _driver.FindElement(element).Click();
            return this;
        }

        public HomePage buttonPrev()
        {
            _driver.FindElement(_clickPrev).Click();
            return this;
        }

        public HomePage buttonBanner()
        {
            _driver.FindElement(_clickBanner).Click();
            return new HomePage(_driver);
        }
        public HomePage buttonBanner2()
        {
            _driver.FindElement(_clickBanner2).Click();
            return new HomePage(_driver);
        }
        public HomePage buttonBanner3()
        {
            _driver.FindElement(_clickBanner3).Click();
            return new HomePage(_driver);
        }
        public HomePage buttonBanner4()
        {
            _driver.FindElement(_clickBanner4).Click();
            return new HomePage(_driver);
        }
        public HomePage buttonBanner5()
        {
            _driver.FindElement(_clickBanner5).Click();
            return new HomePage(_driver);
        }
        public HomePage buttonBanner6()
        {
            _driver.FindElement(_clickBanner6).Click();
            return new HomePage(_driver);
        }
       
    }
}