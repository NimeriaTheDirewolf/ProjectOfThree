using OpenQA.Selenium;

namespace XUnitTestProject4.PageObject.Product
{ //делала Катя
    public class ClickPrintButton : Header
    {
        public ClickPrintButton(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}