using OpenQA.Selenium;
namespace XUnitTestProject4.PageObject.Product
{
    public class Product: Header
    {
        public Product(IWebDriver driver)
        {
            _driver = driver;
        }
        private By _clickProduct = By.ClassName(".hovered .product-name");
        private By _clickTwitt = By.ClassName(".btn-twitter");
        private By _clickFacebook = By.ClassName(".btn-facebook");
        private By _clickGooglePlus = By.ClassName(".btn-google-plus");
        private By _clickPinterest = By.ClassName(".btn-pinterest");
        private By _sendFriendButton = By.Id("send_friend_button");
        private By _clickPrintButton = By.Id("Print");
        private By _clickPlusButton = By.CssSelector(".icon-plus");
        private By _clickMinusButton = By.CssSelector(".icon-minus");
        private By _Dropdown = By.Id("group_1");
        private By _addToCart = By.XPath("//p[@id='add_to_cart']/button/span");
        private By _addWishList = By.Id("wishlist_button");

        public HomePage clickProduct()
        {
            _driver.FindElement(_clickProduct).Click();
            return new HomePage(_driver);
        }
        public ClickTwitt clickTwitt()
        {
            _driver.FindElement(_clickTwitt).Click();
            return new ClickTwitt(_driver);
        }
        public ClickFacebook clickFacebook()
        {
            _driver.FindElement(_clickFacebook).Click();
            return new ClickFacebook(_driver);
        }
        public ClickGooglePlus clickGooglePlus()
        {
            _driver.FindElement(_clickGooglePlus).Click();
            return new ClickGooglePlus(_driver);
        }
        public ClickPinterest clickPinterest()
        {
            _driver.FindElement(_clickPinterest).Click();
            return new ClickPinterest(_driver);
        }
        public ClickSendFriendButton clicksendFriendButton()
        {
            _driver.FindElement(_sendFriendButton).Click();
            return new ClickSendFriendButton(_driver);
        }
        public ClickPrintButton clickPrintButton()
        {
            _driver.FindElement(_clickPrintButton).Click();
            return new ClickPrintButton(_driver);
        }
        public Product clickPlusButton()
        {
            _driver.FindElement(_clickPlusButton).Click();
            return this;
        }
        public Product clickMinusButton()
        {
            _driver.FindElement(_clickMinusButton).Click();
            return this;
        }
        public Product dropDown()
        {
            _driver.FindElement(_Dropdown).Click();
            return this;
        }
        public Product addToCart()
        {
            _driver.FindElement(_addToCart).Click();
            return this;
        }
        public Product addWishList()
        {
            _driver.FindElement(_addWishList).Click();
            return this;
        }
        
    }
}