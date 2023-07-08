using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.Cryptography.X509Certificates;
using TechTalk.SpecFlow;

namespace OrderCarrot.Hooks
{
    [Binding]
    public class WebHooks
    {
        public static IWebDriver driver;

        [BeforeScenario("@tag1")]
        public static void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
        }

            [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}