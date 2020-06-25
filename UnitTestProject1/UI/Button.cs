

namespace UnitTestProject1.UI
{
    using OpenQA.Selenium;

    public static class Button
    {
        private static By botonLupa = By.Name("INICIO");
        private static By btnIniciarSesion = By.XPath("//nav//a[.='Iniciar sesión']");
        private static By btnSiguiente = By.Id("idSIButton9");
        private static By btnBandejaEntrada = By.XPath("//*/span[@class='_16aPYHYIOVxzNYTA4BGnwS NJVykX0WljoRws2qTYI5G']");
        private static By btnSeleccionarPrimerMail = By.XPath("//div/*//div[@class='_1xP-XmXM1GGHpRKCCeOKjP'][1]");
        private static By btnEliminarMail = By.XPath("//div/*//button[@name=\"Eliminar\"]");
        private static By btnCorreoNoDeseado = By.XPath("//div//div[@title='Correo no deseado']");
        private static By btnMensajeNuevo = By.Id("id__3");
        private static By btnEnviarMensaje = By.XPath("//*/button[@title='Enviar (Ctrl+Entrar)']");
        private static By btnMensajesEnviados = By.XPath("//div[@title='Elementos enviados']");
        private static By btnAutoCompletarMail = By.XPath("//div/*//*[@id='suggestion-list']");
        private static By btnLupaOutlook = By.XPath("//button[@aria-label='Buscar']");

        public static By BotonLupa()                { return botonLupa; }
        public static By BtnIniciarSesion()         { return btnIniciarSesion; }
        public static By BtnSiguiente()             { return btnSiguiente; }
        public static By BtnBandejaEntrada()        { return btnBandejaEntrada; }
        public static By BtnSeleccionarPrimerMail() { return btnSeleccionarPrimerMail; }
        public static By BtnCorreoNoDeseado()       { return btnCorreoNoDeseado; }
        public static By BtnEliminarMail()          { return btnEliminarMail; }
        public static By BtnMensajeNuevo()          { return btnMensajeNuevo; }
        public static By BtnEnviarMensaje()         { return btnEnviarMensaje; }
        public static By BtnMensajesEnviados()      { return btnMensajesEnviados; }
        public static By BtnAutoCompletarMail()     { return btnAutoCompletarMail; }
        public static By BtnLupaOutlook()           { return btnLupaOutlook; }
    }
}
