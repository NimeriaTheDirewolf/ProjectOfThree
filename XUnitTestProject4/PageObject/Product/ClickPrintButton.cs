using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject.Product
{
    public class ClickPrintButton : Header
    {
        public ClickPrintButton(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}