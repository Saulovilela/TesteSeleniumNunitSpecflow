using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteSpecflow.Elements;

namespace TesteSpecflow.Pages
{
    public class LoginPage
    {
        public void PreencherLogin(string email, string senha, IWebDriver driver)
        {
            driver.FindElement(By.Id(LoginElements.Username)).SendKeys(email);
            driver.FindElement(By.Id(LoginElements.Password)).SendKeys(senha);
        }
        public void ClicarLogin(IWebDriver driver)
        {
            driver.FindElement(By.Id(LoginElements.BtnLogin)).Click();
        }

    }
}
