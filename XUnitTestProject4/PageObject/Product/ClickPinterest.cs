using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject.Product
{
    public class ClickPinterest : Header
    {
        public ClickPinterest(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}