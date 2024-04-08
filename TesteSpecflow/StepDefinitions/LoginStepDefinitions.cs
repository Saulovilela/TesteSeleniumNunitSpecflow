using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TesteSpecflow.Pages;

namespace TesteSpecflow.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions 
    {
        private readonly LoginPage loginPage;

        public LoginStepDefinitions()  
        {
            loginPage = new LoginPage();
        }

        public IWebDriver driver;
       
        [Given(@"que esteja na pagina do Seu Barriga")]
        public void GivenQueEstejaNaPaginaDoSeuBarriga()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
        }

        [When(@"preencher os dados de login da plataforma")]
        public void WhenPreencherOsDadosDeLoginDaPlataforma()
        {
            loginPage.PreencherLogin("standard_user","sauce_secret",driver);
        }

        [Then(@"clicando em entrar terei feito o login")]
        public void ThenTereiFeitoOLogin()
        {
            loginPage.ClicarLogin(driver);
        }
    }
}
