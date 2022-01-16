using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject
{
   public  class ContactUsPage : HeaderFooter
    {
        public ContactUsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Vlad
        private By _contactusHome = By.XPath("//div[@id='columns']/div/a/i");
        private By _contactusSubjectHeading = By.XPath("//select[@id='id_contact']");
        private By _contactusEmaiLaddress = By.XPath("//input[@id='email']");
        private By _contactusOrderReference = By.XPath("//input[@id='id_order']");
        private By _contactusAttachFile = By.XPath("//div[@id='uniform-fileUpload']/span");
        private By _contactusAttachFileChooseFile = By.XPath("//div[@id='uniform-fileUpload']/span[2]");
        private By _contactusMessage = By.XPath("//textarea[@id='message']");
        private By _contactusSend = By.XPath("//button[@id='submitMessage']/span");

        public ContactUsHome clickHomeBatton()
        {
            _driver.FindElement(_contactusHome).Click();
            return new ContactUsHome(_driver);
        }

        public ContactUsSubjectHeading clickcontactusSubjectHeading()
        {
            _driver.FindElement(_contactusSubjectHeading).Click();
            return new ContactUsSubjectHeading(_driver);
        }

        public EmaiLaddress clickcontactusEmaiLaddress()
        {
            _driver.FindElement(_contactusEmaiLaddress).Click();
            return new EmaiLaddress(_driver);
        }
        public OrderReference clickccontactusOrderReference()
        {
            _driver.FindElement(_contactusOrderReference).Click();
            return new OrderReference(_driver);
        }
        public ContactUsAttachFile clickcontactusAttachFile()
        {
            _driver.FindElement(_contactusAttachFile).Click();
            return new ContactUsAttachFile(_driver);
        }
        public ContactUsAttachFileChooseFile clickcontactusAttachFileChooseFile()
        {
            _driver.FindElement(_contactusAttachFileChooseFile).Click();
            return new ContactUsAttachFileChooseFile(_driver);
        }
        public ContactUsMessage clickcontactusMessage()
        {
            _driver.FindElement(_contactusMessage).Click();
            return new ContactUsMessage(_driver);
        }
        public ContactUsSend clickcontactusSend()
        {
            _driver.FindElement(_contactusSend).Click();
            return new ContactUsSend(_driver);
        }
    }
}

