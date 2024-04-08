using OpenQA.Selenium;
using System.Xml.Linq;
using TechTalk.SpecFlow;
using TesteSpecflow.Pages;

namespace TesteSpecflow.StepDefinitions
{
    [Binding]
    public class CompraDeMochilaStepDefinitions : BaseSteps
    {
        private readonly CompraMochilaPage compraMochilaPage;

        public CompraDeMochilaStepDefinitions()
        {
            compraMochilaPage = new CompraMochilaPage();
        }

        [Given(@"que eu clique na mochila")]
        public void GivenQueEuCliqueNaMochila()
        {
            Thread.Sleep(1000);
            compraMochilaPage.ClicarImagemMochila(driver);
        }



        [When(@"clicar em add ao carrinho")]
        public void WhenClicarEmAddAoCarrinho()
        {
            Thread.Sleep(1000);
            compraMochilaPage.ClickAddToCart(driver);
        }

        [When(@"clicar no carrinho")]
        public void WhenClicarNoCarrinho()
        {
            compraMochilaPage.ClickCart(driver);
        }

        [Then(@"clicar em checkout")]
        public void ThenClicarEmCheckout()
        {
                Thread.Sleep(1000);
            compraMochilaPage.ClickCheckout(driver);
        }

    }
}
