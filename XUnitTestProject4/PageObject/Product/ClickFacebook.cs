using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject.Product
{
    public class ClickFacebook : Header
    {
        public ClickFacebook(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}