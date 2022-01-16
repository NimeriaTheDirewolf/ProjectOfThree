using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject.Cart
{
    public class ClickContinueShopping : Header
    {
        public ClickContinueShopping(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}