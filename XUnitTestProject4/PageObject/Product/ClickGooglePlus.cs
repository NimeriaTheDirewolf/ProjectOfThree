using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject.Product
{
    public class ClickGooglePlus : Header
    {
        public ClickGooglePlus(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}