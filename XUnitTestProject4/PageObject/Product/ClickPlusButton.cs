using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject.Product
{
    public class ClickPlusButton : Header
    {
        public ClickPlusButton(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}