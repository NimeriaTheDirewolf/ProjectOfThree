using OpenQA.Selenium;
namespace XUnitTestProject4.PageObject
{
    public class ButtonSignIn : Header
    { //делала Катя
        IWebDriver _driver;

        public ButtonSignIn(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}