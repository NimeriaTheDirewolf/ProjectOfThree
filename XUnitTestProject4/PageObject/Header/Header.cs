using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace XUnitTestProject4.PageObject
{  
    //Инна и Катя.
   public class Header
    {
        protected IWebDriver _driver;

        private By _headerElement = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/blockbanner/img/sale70.png')]");
        private By _contactUsBtn = By.LinkText("Contact us");
        private By _singInBtn = By.LinkText("Sign in");
        private By _yourLogoElement = By.XPath("//div[3]/div/div/div/a/img");
        private By _searchFieldElement = By.XPath("//input[4]");
        private By _searchSubmittBtn = By.XPath("//button");
        private By _clickShoppingCardBtn = By.XPath("//div[3]/div/a");
        private By _hoverWomenDrop = By.XPath("//a[contains(text(),'Women')]");
        private By _clickTopsElement = By.XPath("//a[contains(text(),'Tops')]");
        private By _clickTshirtsElement = By.LinkText("T-shirts");
        private By _clickBlousersElement = By.LinkText("Blousers");
        private By _clickDressesElement = By.XPath("//a[contains(text(),'Dresses')]");
        private By _clickCasualDressesElement = By.XPath("//a[contains(text(),'Casual Dresses')]");
        private By _clickEveningDressesElement = By.XPath("//a[contains(text(),'Evening Dresses')]");
        private By _clickSummerDressesElement = By.XPath("//a[contains(text(),'Summer Dresses')]");
        private By _clickDressesMainBtn = By.XPath("//div[6]/ul/li[2]/a");
        private By _clickCasualDressesFromMainBtn = By.XPath("//div[6]/ul/li[2]/ul/li/a");
        private By _clickEveningDressesFromMainBtn = By.XPath("//div[6]/ul/li[2]/ul/li[2]/a");
        private By _clickSummerDressesFromMainBtn = By.XPath("//div[6]/ul/li[2]/ul/li[3]/a");
        private By _clickTsirtsMainBtn = By.XPath("//div[6]/ul/li[3]/a");
       
        public Header clickHeaderUpperElemnt()
        {
            _driver.FindElement(_headerElement).Click();
            return this;
        }
        public ContactUsPage clickContactUs()
        {
            _driver.FindElement(_contactUsBtn).Click();
            return new ContactUsPage(_driver);
        }
        public SignInPage clickSingIn()
        {
            _driver.FindElement(_singInBtn).Click();
            return new SignInPage(_driver);
        }
        public Header clickYourLogoElement()
        {
            _driver.FindElement(_yourLogoElement).Click();
            return this;
        }
        public SearchResultPage inputSearchingWord()
        {
            _driver.FindElement(_searchFieldElement).SendKeys("shorts");
            return new SearchResultPage(_driver);
        }
        public SearchResultPage clickSearchBtn()
        {
            _driver.FindElement(_searchSubmittBtn).Click();
            return new SearchResultPage(_driver);
        }
        public ShoppingCardPage clickShoppingCardBtn()
        {
            _driver.FindElement(_clickShoppingCardBtn).Click();
            return new ShoppingCardPage(_driver);
        }
        public Header hoverWomenDrop()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_hoverWomenDrop);
            act.MoveToElement(element).Perform();
            return this;
        }
        public WomenPage clickWomenMainBtn()
        {
            _driver.FindElement(_hoverWomenDrop).Click();
            return new WomenPage(_driver);
        }
        public TopsPage clickTopsElement()
        {
            _driver.FindElement(_clickTopsElement).Click();
            return new TopsPage(_driver);
        }
        public TshirtPage clickTshirtsElement()
        {
            _driver.FindElement(_clickTshirtsElement).Click();
            return new TshirtPage(_driver);
        }
        public BlousesPage clickBlousersElement()
        {
            _driver.FindElement(_clickBlousersElement).Click();
            return new BlousesPage(_driver);
        }
        public DressesPage clickDressesElement()
        {
            _driver.FindElement(_clickDressesElement).Click();
            return new DressesPage(_driver);
        }

        public CasualDressesPage clickCasualDressesElement()
        {
            _driver.FindElement(_clickCasualDressesElement).Click();
            return new CasualDressesPage(_driver);
        }

        public EveningDressesPage clickEveningDressesElement()
        {
            _driver.FindElement(_clickEveningDressesElement).Click();
            return new EveningDressesPage(_driver);
        }

        public SummerDressesPage clickSummerDressesElement()
        {
            _driver.FindElement(_clickSummerDressesElement).Click();
            return new SummerDressesPage(_driver);
        }

        public DressesPage clickDressesMainBtn()
        {
            _driver.FindElement(_clickDressesMainBtn).Click();
            return new DressesPage(_driver);
        }

        public Header hoverDressMainBtn()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_clickDressesMainBtn);
            act.MoveToElement(element).Perform();
            return this;
        }
        public SummerDressesPage clickSummerDressesFromMainBtn()
        {
            _driver.FindElement(_clickSummerDressesFromMainBtn).Click();
            return new SummerDressesPage(_driver);
        }

        public CasualDressesPage clickCasualDressesFromMainBtn()
        {
            _driver.FindElement(_clickCasualDressesFromMainBtn).Click();
            return new CasualDressesPage(_driver);
        }

        public EveningDressesPage clickEveningDressesFromMainBtn()
        {
            _driver.FindElement(_clickEveningDressesFromMainBtn).Click();
            return new EveningDressesPage(_driver);
        }

        public TshirtPage clickTsirtsMainBtn()
        {
            _driver.FindElement(_clickTsirtsMainBtn).Click();
            return new TshirtPage(_driver);
        }
    }
}
