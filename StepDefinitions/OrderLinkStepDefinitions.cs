using OpenQA.Selenium;
using OrderCarrot.Hooks;
using OrderCarrot.PageObject;
using System;
using TechTalk.SpecFlow;

namespace OrderCarrot.StepDefinitions
{
    [Binding]
    public class OrderLinkStepDefinitions
    {
        public IWebDriver driver = WebHooks.driver;
        OrderCarrotPage orderCarrotPage = new OrderCarrotPage();
        
        [Given(@"I navigate to rahulshettyacademy website")]
        public void GivenINavigateToRahulshettyacademyWebsite()
        {
            driver.Navigate().GoToUrl(@"https://rahulshettyacademy.com/seleniumPractise/#/");
        }

        [When(@"I click on the add to cart button on the carrot item")]
        public void WhenIClickOnTheAddToCartButtonOnTheCarrotItem()
        {
            orderCarrotPage.ClickAddToCartButton();
        }

        [When(@"I clicked on the cart icon")]
        public void WhenIClickedOnTheCartIcon()
        {
            orderCarrotPage.ClickTheCartIcon();
        }

        [When(@"I clicked on proceed to checkout")]
        public void WhenIClickedOnProceedToCheckout()
        {
            orderCarrotPage.ClickProceedToCheckOut();
        }

        [When(@"I clicked on the place order button")]
        public void WhenIClickedOnThePlaceOrderButton()
        {
            orderCarrotPage.ClickPlaceOrderButton();
        }

        [When(@"I select country '([^']*)'")]
        public void WhenISelectCountry(string nigeria)
        {
            orderCarrotPage.SelectCountry();
        }

        [When(@"I click on the agree to terms and condition")]
        public void WhenIClickOnTheAgreeToTermsAndCondition()
        {
            orderCarrotPage.ClickAgreeToTermsAndCondition();
        }

        [When(@"I click on place order button")]
        public void WhenIClickOnPlaceOrderButton()
        {
            orderCarrotPage.ClickPlaceOrderButton();
        }


        [Then(@"a successful message is displayed")]
        public void ThenASuccessfulMessageIsDisplayed()
        {
            orderCarrotPage.IsSuccessfulMessageIsDisplayed().Should().BeFalse();
        }

        [Then(@"I am redirected to the home page")]
        public bool ThenIAmRedirectedToTheHomePage()
        {
            return driver.Url.Equals("https://rahulshettyacademy.com/seleniumPractise/#/");
        }
    }
}
