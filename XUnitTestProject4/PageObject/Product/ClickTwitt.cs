using OpenQA.Selenium;namespace XUnitTestProject4.PageObject.Product
{
    public class ClickTwitt : Header
    {
        public ClickTwitt(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}