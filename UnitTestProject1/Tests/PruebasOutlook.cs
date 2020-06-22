namespace UnitTestProject1.Tests
{
    using NUnit.Framework;
    using UnitTestProject1.Tasks;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System;
    using UI;

    public class PruebasDiarios : BaseTest
    {
        [SetUp, Description("Configraciones iniciales.")]
        public void InicioSuite()
        {
            Driver.Init();
            //Driver.GetIntance().Navigate().GoToUrl("http://www.clarin.com.ar");
        }

        [Test, Description("Busca en Clarin")]
        public void TestBusquedaPinoEnClarin()
        {
            Driver.GetIntance().Navigate().GoToUrl("http://www.clarin.com.ar");
            Navegación.ClickFueraDelPopUp();
            Navegación.buscar("pino");
            Assert.IsTrue(Validaciones.BuscadorLargoVisible(), "Falló la búsqueda de pino en clarin");
        }
              
        [Test, Description("Acceder a Outlook desde google.")]
        public void TestAccederAOutlookDesdeGoogle()
        {
            Navegación.IrAUrl("https://www.google.com.ar/");
            Navegación.BusquedaEnGoogle("Outlook");
            Assert.IsTrue(Validaciones.TituloOutlookVisible("Outlook – free personal email and calendar from Microsoft"), "No se encontró el título de Outlook");
        }

        [Test, Description("Acceder a Outlook desde google.")]
        public void TestLogueoEnOutlook()
        {
            Navegación.IrAUrl("https://www.google.com.ar/");
            Navegación.BusquedaEnGoogle("Outlook");
            Navegación.LogInOutlook("willian.cabezasroa@outlook.com", "cordero4376");
            Assert.IsTrue(Validaciones.SeMuestraBotonBandejaDeEntrada(), "Fallo el logueo en Outlook");
        }


    }
}
