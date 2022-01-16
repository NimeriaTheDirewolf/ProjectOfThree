using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace XUnitTestProject4.PageObject
{
    class HeaderFooter
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
       
        public HeaderFooter clickHeaderUpperElemnt()
        {
            _driver.FindElement(_headerElement).Click();
            return this;
        }
        public ContactUsPage clickContactUs()
        {
            _driver.FindElement(_contactUsBtn).Click();
            return new ContactUsPage(_driver);
        }
        public SignInPage SignInClick()
        {
            _driver.FindElement(_singInBtn).Click();
            return new SignInPage(_driver);
        }
        public HeaderFooter clickYourLogoElement()
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
        public HeaderFooter hoverWomenDrop()
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

        public HeaderFooter hoverDressMainBtn()
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

        public static implicit operator HeaderFooter(HomePage v)
        {
            throw new NotImplementedException();
        }

        private By _footerBarAbouteUs = By.LinkText("About us");
        private By _footerBarBestSellers = By.LinkText("Best sellers");
        private By _footerBarContactUs = By.LinkText("Contact us");
        private By _footerBarMyAddresses = By.XPath("//a[contains(text(),'Our stores')]");
        private By _footerBarMyCreditSlips = By.XPath("//footer[@id='footer']/div/section[5]/div/ul/li[2]/a");
        private By _footerBarMyOrders = By.XPath("//a[contains(text(),'My orders')]");
        private By _footerBarMyPersonalInfo = By.LinkText("MyPersonalInfo");
        private By _footerBarNewProducts = By.LinkText("New products");
        private By _footerBarOurStores = By.XPath("//section[@id='block_various_links_footer']/ul/li[4]/a");
        private By _footerBarSiteMap = By.LinkText("Sitemap");
        private By _footerBarSpecials = By.LinkText("Specials");
        private By _footerBarTermsAndConditionsOfUse = By.XPath("//a[contains(text(),'Terms and conditions of use')]");
        private By _footerBarEmailSupport = By.LinkText("support@seleniumframework.com");
        private By _footerBarMyAccount = By.LinkText("My account");
        private By _footerBarGoogle = By.XPath("//section[@id='social_block']/ul/li[4]/a");
        private By _footerBarYouTube = By.XPath("//section[@id='social_block']/ul/li[3]/a");
        private By _footerBarTwitter = By.XPath("//section[@id='social_block']/ul/li[2]/a");
        private By _footerBarFacebook = By.XPath("//section[@id='social_block']/ul/li/a");
        private By _footerBarNewsLetter = By.Id("newsletter-input");
        private By _footerBarBattonNewsletter = By.XPath("//button[@name='submitNewsletter']");

        public AboutUs clickAbouteUs()
        {
            _driver.FindElement(_footerBarAbouteUs).Click();
            return new AboutUs(_driver);
        }
        public BestSellers clickBestSellers()
        {
            _driver.FindElement(_footerBarBestSellers).Click();
            return new BestSellers(_driver);
        }
        // public ContactUs clickContactUs()
        // {
        //     _driver.FindElement(_footerBarContactUs).Click();
        //     return new ContactUs(_driver);
        // }
        public MyAddresses clickMyAddresses()
        {
            _driver.FindElement(_footerBarMyAddresses).Click();
            return new MyAddresses(_driver);
        }
        public MyCreditSlips clickMyCreditSlips()
        {
            _driver.FindElement(_footerBarMyCreditSlips).Click();
            return new MyCreditSlips(_driver);
        }

        public MyOrders clickMyOrders()
        {
            _driver.FindElement(_footerBarMyOrders).Click();
            return new MyOrders(_driver);
        }
        public MyPersonalInfo clickMyPersonalInfo()
        {
            _driver.FindElement(_footerBarMyPersonalInfo).Click();
            return new MyPersonalInfo(_driver);
        }
        public NewProducts clickNewProducts()
        {
            _driver.FindElement(_footerBarNewProducts).Click();
            return new NewProducts(_driver);
        }
        public OurStores clickOurStores()
        {
            _driver.FindElement(_footerBarOurStores).Click();
            return new OurStores(_driver);
        }
        public SiteMap clickSiteMap()
        {
            _driver.FindElement(_footerBarSiteMap).Click();
            return new SiteMap(_driver);
        }
        public Specials clickSpecials()
        {
            _driver.FindElement(_footerBarSpecials).Click();
            return new Specials(_driver);
        }
        public TermsAndConditionsOfUse clickTermsAndConditionsOfUse()
        {
            _driver.FindElement(_footerBarTermsAndConditionsOfUse).Click();
            return new TermsAndConditionsOfUse(_driver);
        }
        public EmailSupport clickEmailSupport()
        {
            _driver.FindElement(_footerBarEmailSupport).Click();
            return new EmailSupport(_driver);
        }
        public MyAccount clickMyAccount()
        {
            _driver.FindElement(_footerBarMyAccount).Click();
            return new MyAccount(_driver);
        }
        public Google clickGoogle()
        {
            _driver.FindElement(_footerBarGoogle).Click();
            return new Google(_driver);
        }
        public Facebook clickFacebook()
        {
            _driver.FindElement(_footerBarFacebook).Click();
            return new Facebook(_driver);
        }
        public YouTube clickYouTube()
        {
            _driver.FindElement(_footerBarYouTube).Click();
            return new YouTube(_driver);
        }
        public Twitter clickTwitter()
        {
            _driver.FindElement(_footerBarTwitter).Click();
            return new Twitter(_driver);
        }
        public NewsLetter clickNewsLetter()
        {
            _driver.FindElement(_footerBarNewsLetter).Click();
            return new NewsLetter(_driver);
        }
        public BattonNewsletter clickBattonNewsletter()
        {
            _driver.FindElement(_footerBarBattonNewsletter).Click();
            return new BattonNewsletter(_driver);
        }
    }

    
}
