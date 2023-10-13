using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace CastingWeb.Actions
{
    public class Config
    {
        public IWebDriver Driver { get; private set; }
        public string Url { get; private set; }

        public Config(AmbienteEnum ambiente)
        {
            var ambienteManager = new Ambiente();
            Url = ambienteManager.ObterUrl(ambiente);

            InitializeWebDriver();
        }

        private void InitializeWebDriver()
        {
            var options = new ChromeOptions();
            options.AddArguments("--start-maximized");

            Driver = new ChromeDriver(options);

            // Configurar espera implícita global
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(10);
        }

        public void Cleanup()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver.Dispose();
            }
        }
    }
}
