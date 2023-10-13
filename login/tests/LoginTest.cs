using CastingWeb.Actions;
using CastingWeb.Pages;
using NUnit.Framework;
using TestProject8.config;

namespace TestProject8.Tests
{
    [TestFixture]
    public class LoginTest
    {
        private Config _config;
        private PageLogin _page;
        private Actions _actions;
        private User _user;

        [SetUp]
        public void Setup()
        {
            _config = new Config(AmbienteEnum.Homologacao);
            _page = new PageLogin(_config.Driver);
            _user = User.BD118;
            _actions = new Actions(_page, _user);
        }

        [Test]
        public void TestLogin()
        {
            string url = _config.Url;
            _config.Driver.Navigate().GoToUrl(url);

            // Faz login usando as informações do usuário
            _actions.FazerLogin();
         

            // Adicione asserções para verificar se o login foi bem-sucedido
            // Por exemplo:
            // Assert.IsTrue(_config.Driver.FindElement(By.Id("algumElementoNaPagina")).Displayed);
        }

        [TearDown]
        public void Teardown()
        {
           // _config.Cleanup();
        }
    }
}
