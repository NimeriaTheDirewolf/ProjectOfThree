using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject.Product
{ //делала Катя
    public class ClickGooglePlus : Header
    {
        public ClickGooglePlus(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}