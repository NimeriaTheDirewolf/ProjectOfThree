using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace XUnitTestProject4.PageObject
{
    class HomePage 
    {   
        //Инна и Катя.
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
        private By _clickPopularElement = By.XPath("//a[contains(text(),'Popular')]");
        private By _clickBestSellersElement = By.XPath("//div[2]/div/ul/li[2]/a");
        private By _fadedShrtSlvTshirtElem = By.XPath("//div[2]/div/ul/li[2]/a");
        private By _addToCartBtnFadedShortsSleev = By.XPath("//span[contains(.,'Add to cart')]");
        private By _clickContiniueShoppingBtn = By.XPath("//li[2]/div/div[2]/div[2]/a/span");
        private By _clickProceedToCheckoutBtn = By.XPath("//div[2]/div/ul/li[2]/a");
        private By _clickCloseWindowInAddToCart = By.XPath("///div[4]/div/div/span");
        private By _clickFadedShortMoreBtn = By.XPath("//span[contains(.,'More')]");
        private By _blouseItemElement = By.XPath("//div[3]/div/ul/li[2]/a");
        private By _addToCartBtnBlouseItem = By.XPath("//div[2]/div/ul/li[2]/a");
        private By _clickBlouseMoreBtn = By.XPath("//div[2]/div/ul/li[2]/a");
        private By _printedDressElement = By.XPath("//li[2]/div/div[2]/div[2]/a/span");
        private By _addToCartPrintedDress = By.XPath("//li[2]/div/div[2]/div[2]/a/span");
        private By _clickPrintedDressMoreBtn = By.XPath("//div[2]/div/ul/li[2]/a");
        private By _printedDress2Element = By.XPath("//li[2]/div/div[2]/div[2]/a/span");
        private By _addToCartPrintedDress2 = By.XPath("//li[4]/div/div[2]/div[2]/a/span");
        private By _clickPrintedDress2MoreBtn = By.XPath("//div[2]/a[2]/span");
        private By _printedSummerDress = By.XPath("//li[2]/div/div[4]/div[2]/a/span");
        private By _addToCartPrintedSummerDress = By.XPath("//div[2]/div/ul/li[2]/a");
        private By _clickPrintedSummerDrMoreBtn = By.XPath("//div[5]/a[2]/span");
        private By _printedSummerDress2 = By.XPath("//div[2]/div/ul/li[2]/a");
        private By _clickPrintedSummerDr2MoreBtn = By.XPath("//div[2]/div/ul/li[2]/a");
        private By _addToCartPrintedSummerDress2 = By.XPath("/li[7]/div/div[2]/div[2]/a[2]/span");
        private By _printedChiffonDress = By.LinkText("Printed Chiffon Dress");
        private By _addToCartPrintedChiffonDress = By.XPath("//div[4]/div/div/span");
        private By _clickChiffonDressMoreBtn = By.XPath("//li[7]/div/div[2]/h5/a");
        
        private By _clickButtonShopNow = By.CssSelector(".homeslider-container:nth-child(2) .btn");
        private By _clickNext = By.XPath("//a[contains(text(),'Next')]");
        private By _clickPrev = By.XPath("//a[contains(text(),'Prev')]");
        private By _clickBanner = By.CssSelector("#htmlcontent_top .htmlcontent-item-1 .item-img");
        private By _clickBanner2 = By.CssSelector(".htmlcontent-item-3 .item-img");
        private By _clickBanner3 = By.CssSelector("#htmlcontent_home .htmlcontent-item-1 .item-img");
        private By _clickBanner4 = By.CssSelector(".htmlcontent-item-5 .item-img");
        private By _clickBanner5 = By.CssSelector("htmlcontent-item-4 .item-img");
        private By _clickBanner6 = By.CssSelector("#htmlcontent_home .htmlcontent-item-2 .item-img");
        private IWebDriver _driver;

        public HomePage clickPopularElement()
        {
            _driver.FindElement(_clickPopularElement).Click();
            return this;
        }
        public HomePage clickBestSellersElement()
        {
            _driver.FindElement(_clickBestSellersElement).Click();
            return this;
        }
        // Методы для первого продукта.
        public HomePage hoverFadedShortSleevTshirt()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_fadedShrtSlvTshirtElem);
            act.MoveToElement(element).Perform();
            return this;
        }
        public FadedShortSleeveTshirts clickFadedShortsSleevElement()
        {
            _driver.FindElement(_fadedShrtSlvTshirtElem).Click();
            return new FadedShortSleeveTshirts(_driver);
        }
        public HomePage clickAddToCartBtnFadedShortsSleev()
        {
            _driver.FindElement(_addToCartBtnFadedShortsSleev).Click();
            return this;
        }
        // Метод, нажимает "Продолжить шоппинг"( один и тот же локатор на все продукты).
        public HomePage clickContiniueShoppingBtn()
        {
            _driver.FindElement(_clickContiniueShoppingBtn).Click();
            return this;
        }
        // Метод, нажимает "Proceed To Checkout" для всех товаров.
        public ShoppingCardPage clickProceedToCheckoutBtn()
        {
            _driver.FindElement(_clickProceedToCheckoutBtn).Click();
            return new ShoppingCardPage(_driver);
        }
        // Метод, закрывающий любое окно если нажать "Добавить в корзину" на черный крестик.
        public HomePage clickCloseWindowInAddToCart()
        {
            _driver.FindElement(_clickCloseWindowInAddToCart).Click();
            return this;
        }
        public FadedShortSleeveTshirts clickMoreBtn()
        {
            _driver.FindElement(_clickFadedShortMoreBtn).Click();
            return new FadedShortSleeveTshirts(_driver);
        }
        // Методы для второго продукта.
        public HomePage hoverBlouseItem()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_blouseItemElement);
            act.MoveToElement(element).Perform();
            return this;
        }

        public BlouseItemPage clickBlouseItemElement()
        {
            _driver.FindElement(_blouseItemElement).Click();
            return new BlouseItemPage(_driver);
        }
        public HomePage clickAddToCartBtnBlouseItem()
        {
            _driver.FindElement(_addToCartBtnBlouseItem).Click();
            return this;
        }
        public BlouseItemPage clickBlouseMoreBtn()
        {
            _driver.FindElement(_clickBlouseMoreBtn).Click();
            return new BlouseItemPage(_driver);
        }
        // Методы для третьего продукта.
        public HomePage hoverPrintedDress()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedDressElement);
            act.MoveToElement(element).Perform();
            return this;
        }
        public PrintedDressPage clickPrintedDressElement()
        {
            _driver.FindElement(_printedDressElement).Click();
            return new PrintedDressPage(_driver);
        }
        public HomePage clickAddToCartprintedDressBtn()
        {
            _driver.FindElement(_addToCartPrintedDress).Click();
            return this;
        }
        public PrintedDressPage clickPrintedDressElementMoreBtn()
        {
            _driver.FindElement(_clickPrintedDressMoreBtn).Click();
            return new PrintedDressPage(_driver);
        }
        // Методы для четвертого продукта.
        public HomePage hoverPrintedDress2()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedDress2Element);
            act.MoveToElement(element).Perform();
            return this;
        }
        public PrintedDress2Page clickPrintedDress2Element()
        {
            _driver.FindElement(_printedDressElement).Click();
            return new PrintedDress2Page(_driver);
        }
        public HomePage clickAddToCartPrintedDress2Btn()
        {
            _driver.FindElement(_addToCartPrintedDress2).Click();
            return this;
        }
        public PrintedDress2Page clickPrintedDress2MoreBtn()
        {
            _driver.FindElement(_clickPrintedDress2MoreBtn).Click();
            return new PrintedDress2Page(_driver);
        }
        // Методы для пятого продукта.
        public HomePage hoverPrintedSummerDress()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedSummerDress);
            act.MoveToElement(element).Perform();
            return this;
        }
        public PrintedSummerDressPage clickPrintedSummerDressElem()
        {
            _driver.FindElement(_printedDressElement).Click();
            return new PrintedSummerDressPage(_driver);
        }
        public HomePage clickAddToCartPrintedSummerDressBtn()
        {
            _driver.FindElement(_addToCartPrintedSummerDress).Click();
            return this;
        }
        public PrintedSummerDressPage clickPrintedSummerDressMoreBtn()
        {
            _driver.FindElement(_clickPrintedSummerDrMoreBtn).Click();
            return new PrintedSummerDressPage(_driver);
        }
        // Методы для шестого продукта.
        public HomePage hoverPrintedSummerDress2()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedSummerDress2);
            act.MoveToElement(element).Perform();
            return this;
        }
        public PrintedSummerDress2Page clickPrintedSummerDress2Elem()
        {
            _driver.FindElement(_printedDress2Element).Click();
            return new PrintedSummerDress2Page(_driver);
        }
        public HomePage clickAddToCartPrintedSummerDress2Btn()
        {
            _driver.FindElement(_addToCartPrintedSummerDress2).Click();
            return this;
        }
        public PrintedSummerDress2Page clickPrintedSummerDress2MoreBtn()
        {
            _driver.FindElement(_clickPrintedSummerDr2MoreBtn).Click();
            return new PrintedSummerDress2Page(_driver);
        }
        // Методы для седьмого продукта.
        public HomePage hoverPrintedChiffinDress()
        {
            Actions act = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedChiffonDress);
            act.MoveToElement(element).Perform();
            return this;
        }
        public PrintedChiffonDressPage clickPrintedChiffonDressElem()
        {
            _driver.FindElement(_printedChiffonDress).Click();
            return new PrintedChiffonDressPage(_driver);
        }
        public HomePage clickAddToCartPrintedChiffonDressBtn()
        {
            _driver.FindElement(_addToCartPrintedChiffonDress).Click();
            return this;
        }
        public PrintedChiffonDressPage clickPrintedChiffonDressMoreBtn()
        {
            _driver.FindElement(_clickChiffonDressMoreBtn).Click();
            return new PrintedChiffonDressPage(_driver);
        }





        public HomePage buttonShopNow()
        {
            _driver.FindElement(_clickButtonShopNow).Click();
            return new HomePage(_driver);
        }

        public HomePage buttonNext(By element)
        {
            _driver.FindElement(element).Click();
            return this;
        }

        public HomePage buttonPrev()
        {
            _driver.FindElement(_clickPrev).Click();
            return this;
        }

        public HomePage buttonBanner()
        {
            _driver.FindElement(_clickBanner).Click();
            return new HomePage(_driver);
        }
        public HomePage buttonBanner2()
        {
            _driver.FindElement(_clickBanner2).Click();
            return new HomePage(_driver);
        }
        public HomePage buttonBanner3()
        {
            _driver.FindElement(_clickBanner3).Click();
            return new HomePage(_driver);
        }
        public HomePage buttonBanner4()
        {
            _driver.FindElement(_clickBanner4).Click();
            return new HomePage(_driver);
        }
        public HomePage buttonBanner5()
        {
            _driver.FindElement(_clickBanner5).Click();
            return new HomePage(_driver);
        }
        public HomePage buttonBanner6()
        {
            _driver.FindElement(_clickBanner6).Click();
            return new HomePage(_driver);
        }
        
       

    }
}