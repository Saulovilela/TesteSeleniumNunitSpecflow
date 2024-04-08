using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TesteSpecflow.Pages;

namespace TesteSpecflow.StepDefinitions
{
    public class BaseSteps
    {
        protected readonly IWebDriver driver;
        protected readonly LoginPage loginPage;

        public BaseSteps()
        {
            driver = Hooks.GetDriver(); 
            loginPage = new LoginPage();
        }

        [BeforeScenario]
        public void Setup()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            loginPage.PreencherLogin("standard_user", "secret_sauce", driver);
            loginPage.ClicarLogin(driver);
        }
    }
}

