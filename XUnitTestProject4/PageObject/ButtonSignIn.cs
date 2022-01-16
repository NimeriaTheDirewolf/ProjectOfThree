using OpenQA.Selenium;
namespace XUnitTestProject4.PageObject
{
    public class ButtonSignIn : HeaderFooter
    {
        IWebDriver _driver;

        public ButtonSignIn(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}