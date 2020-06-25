namespace UnitTestProject1.Tests
{
    using NUnit.Framework;
    using UnitTestProject1.Tasks;

    public class PruebasOutlook : BaseTest
    {

        [Test, Description("Acceder a Outlook desde google.")]
        public void TestAccederAOutlookDesdeGoogle()
        {
            Navegación.IrAUrl("https://www.google.com.ar/");
            Navegación.BusquedaEnGoogle("Outlook");
            Assert.IsTrue(Validaciones.TituloOutlookVisible("Outlook – free personal email and calendar from Microsoft"), "No se encontró el título de Outlook");
        }

        [Test, Description("LogIn en Outlook")]
        public void TestLogueoEnOutlook()
        {
            Navegación.IrAUrl("https://www.google.com.ar/");
            Navegación.BusquedaEnGoogle("Outlook");
            Navegación.LogInOutlook("willian.cabezasroa@outlook.com", "cordero4376");
            Assert.IsTrue(Validaciones.SeMuestraBotonBandejaDeEntrada(), "Fallo el logueo en Outlook");
        }

        [Test, Description("Borrar Spam")]
        public void TestBorrarSpamOutlook()
        {
            Navegación.IrAUrl("https://www.google.com.ar/");
            Navegación.BusquedaEnGoogle("Outlook");
            Navegación.LogInOutlook("willian.cabezasroa@outlook.com", "cordero4376");
            Navegación.EliminarSpam();
            Assert.IsTrue(Validaciones.TextoDeMailEliminado(), "Fallo la eliminación de correo Spam");
        }

        [Test, Description("Enviar Mail")]
        public void TestEnviarMailOutlook()
        {
            Navegación.IrAUrl("https://www.google.com.ar/");
            Navegación.BusquedaEnGoogle("Outlook");
            Navegación.LogInOutlook("willian.cabezasroa@outlook.com", "cordero4376");
            Navegación.EnviarMailOutlook();
            Navegación.IrAMensajesEnviados();
            Assert.IsTrue(Validaciones.ElMensajeFueEnviado(), "Fallo el envio de mensaje desde outlook");
        }

        [Test, Description("Buscar mail por asunto y eliminarlo")]
        public void TestEliminarMailBuscadoPorAsunto()
        {
            Navegación.IrAUrl("https://www.google.com.ar/");
            Navegación.BusquedaEnGoogle("Outlook");
            Navegación.LogInOutlook("willian.cabezasroa@outlook.com", "cordero4376");
            Navegación.BuscarMensaje();
            Navegación.EliminarMensaje();
            Assert.IsTrue(Validaciones.TextoDeMailEliminado(),"Fallo la eliminacion del mensaje");
        }
    }
}
