using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject.Cart
{
    public class Cart : Header
    {
        public Cart(IWebDriver driver)
        {
            _driver = driver;
        }
        private By _clickCart = By.CssSelector(".shopping_cart > a");
        private By _clickContinueShopping = By.LinkText("Continue shopping");
        private By _clickCheckout = By.CssSelector(".standard-checkout > span");
        private By _clickTrash = By.CssSelector(".icon-trash");
        
        public Header clickCart()
        {
            _driver.FindElement(_clickCart).Click();
            return new Cart(_driver);
        }
        public ClickContinueShopping clickContinueShopping()
        {
            _driver.FindElement(_clickContinueShopping).Click();
            return new ClickContinueShopping(_driver);
        }
        public ClickCheckout clickCheckout()
        {
            _driver.FindElement(_clickCheckout).Click();
            return new ClickCheckout(_driver);
        }
        public ClickTrash clickTrash()
        {
            _driver.FindElement(_clickTrash).Click();
            return new ClickTrash(_driver);
        }
    }
}