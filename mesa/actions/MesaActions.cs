using Mesa.mesa.page;
using OpenQA.Selenium;
using System;

namespace Mesa.mesa.actions
{
    class MesaActions
    {
        private MesaPage mesaPage;

        public MesaActions(MesaPage mesaPage)
        {
            this.mesaPage = mesaPage;
        }


        public void ClicarModuloMesa()
        {
            mesaPage.ModuloMesa.Click();
        }

        public void clicarEmMetasDiarias()
        {
            mesaPage.metasDiarias.Click();
        }

        public void inserirMetaDiaria1(string valor1)
        {
            mesaPage.inserirMetaDiaria1.Clear();
            mesaPage.inserirMetaDiaria1.SendKeys(valor1.ToString());
        }

        public void inserirMetaDiaria2(string valor2)
        {
            mesaPage.inserirMetaDiaria2.Clear();
            mesaPage.inserirMetaDiaria2.SendKeys(valor2.ToString());
        }

        public void salvarMeta()
        {
            mesaPage.clicarBtnSalvar.Click();
            
        }

    }
}

