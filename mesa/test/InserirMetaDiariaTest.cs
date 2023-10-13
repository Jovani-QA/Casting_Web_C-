using CastingWeb.Actions;
using CastingWeb.Pages;
using NUnit.Framework;
using TestProject8.config;
using Mesa.mesa.page;
using Mesa.mesa.actions;

namespace Mesa.mesa.test
{
    [TestFixture]
    class InserirMetaDiariaTest
    {
        private Config config;
        private PageLogin page;
        private Actions actions;
        private User user;
        private MesaPage mesaPage; // Adicione uma instância de MesaPage
        private MesaActions mesaActions; // Adicione uma instância de MesaActions
        string valor1 = "1000";
        string valor2 = "1200";

        [SetUp]
        public void Setup()
        {
            config = new Config(AmbienteEnum.Homologacao);
            page = new PageLogin(config.Driver);
            user = User.BD118;
            actions = new Actions(page, user);
            mesaPage = new MesaPage(config.Driver); // Inicialize MesaPage com o driver
            mesaActions = new MesaActions(mesaPage); // Inicialize MesaActions com a instância de MesaPage
        }

        [Test]
        public void salvarMetaDiaria()
        {
            string url = config.Url;
            config.Driver.Navigate().GoToUrl(url);

            actions.FazerLogin();
            mesaActions.ClicarModuloMesa();
            mesaActions.clicarEmMetasDiarias();
            mesaActions.inserirMetaDiaria1(valor1.ToString());
            mesaActions.inserirMetaDiaria2(valor2.ToString());
            mesaActions.salvarMeta();

            MetasDiariasValidation.ValidarSomaMetasDiarias(valor1.ToString(), valor2.ToString(), config.Driver);
        }



        [TearDown]
        public void Teardown()
        {
            // _config.Cleanup();
        }
    }
}
