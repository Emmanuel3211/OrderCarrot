using OpenQA.Selenium;
using OrderCarrot.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCarrot.PageObject
{
    class OrderCarrotPage
    {
        public IWebDriver driver;
        
        public OrderCarrotPage() 
        {
            driver = WebHooks.driver;
        }
        private By cartButton = By.XPath("//*[@id=\"root\"]/div/div[1]/div/div[5]/div[3]/button");
        private By cartIcon = By.XPath("//*[@id=\"root\"]/div/header/div/div[3]/a[4]/img");
        private By proceedToCheckOut = By.XPath("//*[@id=\"root\"]/div/header/div/div[3]/div[2]/div[2]/button");
        private By placeOrder = By.XPath("//*[@id=\"root\"]/div/div/div/div/button");
        private By selectButton = By.XPath("//*[@id=\"root\"]/div/div/div/div/div/select");
        private By selectNigeria = By.XPath("//*[@id=\"root\"]/div/div/div/div/div/select");
        private By checkBox = By.XPath("//*[@id=\"root\"]/div/div/div/div/input");
        private By proceedButton = By.XPath("//*[@id=\"root\"]/div/div/div/div/button");
       

        internal void ClickAddToCartButton()
        {
            driver.FindElement(cartButton).Click();
        }

        internal void ClickTheCartIcon()
        {
            driver.FindElement(cartIcon).Click();
        }

        internal void ClickProceedToCheckOut()
        {
            driver.FindElement(proceedToCheckOut).Click();
        }

        internal void ClickPlaceOrderButton()
        {
            driver.FindElement(placeOrder).Click(); ;
        }

        internal void SelectCountry()
        {
            driver.FindElement(selectNigeria).Click();
        }

        internal void ClickAgreeToTermsAndCondition()
        {
            driver.FindElement(checkBox).Click();
        }

        internal bool IsSuccessfulMessageIsDisplayed()
        {
            return driver.Url.Equals("https://rahulshettyacademy.com/seleniumPractise/#/");
        }

        
    }
}
