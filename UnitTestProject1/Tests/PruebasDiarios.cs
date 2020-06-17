namespace UnitTestProject1.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using UnitTestProject1.Tasks;

    [TestClass]
    public class PruebasDiarios : BaseTest
    {
        [TestInitialize]
        public void InicioSuite()
        {
            Driver.GetIntance().Navigate().GoToUrl("http://www.clarin.com.ar");
        }

        [TestMethod]
        public void TestBusquedaPinoEnClarin()
        {
            Navegación.buscar("pino");

        }
              
        [TestCleanup]
        public void FinSuite()
        {

        }
    }
}
