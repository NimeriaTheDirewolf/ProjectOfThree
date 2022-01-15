using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using XUnitTestProject4.PageObject;


namespace XUnitTestProject4
{
    public class UnitTest1:BaseTest
    {
        IWebDriver driver;

        [Fact]
        public void BannerTest()
        {
            driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HeaderFooter homePage = new HomePage(driver);
            homePage.clickHeaderUpperElemnt();

        }
        [Fact]
        public void PopularTest()
        {
            driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new HomePage(driver);
            homePage.clickPopularElement();

        }
    }
}
