using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject.Cart
{
    public class ClickCheckout : Header
    {
        public ClickCheckout(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}