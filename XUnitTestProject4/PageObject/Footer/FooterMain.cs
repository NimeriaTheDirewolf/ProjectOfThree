using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using XUnitTestProject4.PageObject.Footer;

namespace XUnitTestProject4.PageObject
{
    public class FooterMain 
    {
        protected IWebDriver _driver;
        // ves Footer Vlad
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
        private By _footerBarWomen = By.LinkText("Women");

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
        public ContactUs clickContactUs()
        {
            _driver.FindElement(_footerBarContactUs).Click();
            return new ContactUs(_driver);
        }
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
            _driver.FindElement (_footerBarNewsLetter).Click();
            return new NewsLetter(_driver);
        }
        public BattonNewsletter clickBattonNewsletter()
        {
            _driver.FindElement(_footerBarBattonNewsletter).Click();
            return new BattonNewsletter(_driver);
        }
        public Women clickWomenPage()
        {
            _driver.FindElement(_footerBarWomen).Click();
            return new Women(_driver);
        }
    }
    }


  
