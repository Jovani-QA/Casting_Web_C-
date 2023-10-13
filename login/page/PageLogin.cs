using OpenQA.Selenium;

namespace CastingWeb.Pages
{
    public class PageLogin
    {
        private IWebDriver _driver;

        // Construtor que recebe uma instância de IWebDriver para interagir com o navegador
        public PageLogin(IWebDriver driver)
        {
            _driver = driver;
        }

        // Mapeamento dos elementos da página de login
        public IWebElement UsuarioInput => _driver.FindElement(By.XPath("//*[@id='UserName']"));
        public IWebElement SenhaInput => _driver.FindElement(By.XPath("//*[@id='Password']"));
        public IWebElement EntrarButton => _driver.FindElement(By.XPath("//*[@id='btnEntrar']"));
    }
}
