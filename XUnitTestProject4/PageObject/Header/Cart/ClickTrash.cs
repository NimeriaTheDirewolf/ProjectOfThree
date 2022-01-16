using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject.Cart
{
    public class ClickTrash : Header
    {
        public ClickTrash(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}