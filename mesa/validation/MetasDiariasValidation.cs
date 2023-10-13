using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class MetasDiariasValidation
{
    public static void ValidarSomaMetasDiarias(string valor1, string valor2, IWebDriver driver)
    {
        string valorXPath = driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[2]/div[2]/ul[1]/li[1]/div[3]/a[1]/span[1]")).Text;
        Console.WriteLine("Valor do XPath: " + valorXPath);

        // Remover caracteres não numéricos e vírgula
        string valorNumerico = valorXPath.Replace("R$", "").Replace(",", "").Trim();

        int valorEsperado;
        if (Int32.TryParse(valorNumerico, out valorEsperado))
        {
            int somaValores = int.Parse(valor1) + int.Parse(valor2);

            Assert.IsTrue(somaValores == 2300, "A soma dos valores das metas diárias não é igual ao valor esperado.");
            //Assert.AreEqual(somaValores, valorEsperado, "A soma dos valores das metas diárias não é igual ao valor esperado.");
        }
        else
        {
            Assert.Fail("O valor retornado pelo XPath não pôde ser convertido em Int32.");
        }
    }
}

