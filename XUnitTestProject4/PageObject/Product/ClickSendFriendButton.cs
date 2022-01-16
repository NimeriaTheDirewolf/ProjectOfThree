using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject.Product
{ //делала Катя
    public class ClickSendFriendButton : Header
    {
        public ClickSendFriendButton(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}