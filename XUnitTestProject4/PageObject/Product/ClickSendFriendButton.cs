using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject.Product
{
    public class ClickSendFriendButton : Header
    {
        public ClickSendFriendButton(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}