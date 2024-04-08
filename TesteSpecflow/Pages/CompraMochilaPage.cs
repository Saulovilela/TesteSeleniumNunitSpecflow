using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteSpecflow.Elements;

namespace TesteSpecflow.Pages
{
    public class CompraMochilaPage
    {
        public void ClicarImagemMochila(IWebDriver driver)
        {
            driver.FindElement(By.XPath(CompraMochilaElements.ImageMochila)).Click();
        }
        public void ClicaMochila(IWebDriver driver)
        {
            driver.FindElement(By.XPath(CompraMochilaElements.BtnAddMochila)).Click();
        }
        public void ClickAddToCart(IWebDriver driver)
        {
            driver.FindElement(By.XPath(CompraMochilaElements.BtnAddToCart)).Click();
        }
        public void ClickCart(IWebDriver driver)
        {
            driver.FindElement(By.ClassName(CompraMochilaElements.BtnCart)).Click();
        }
        public void ClickCheckout(IWebDriver driver)
        {
            driver.FindElement(By.XPath(CompraMochilaElements.BtnCheckout)).Click();    
        }
    }
}
