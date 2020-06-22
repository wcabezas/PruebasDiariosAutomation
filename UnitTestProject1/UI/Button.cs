

namespace UnitTestProject1.UI
{
    using OpenQA.Selenium;

    public static class Button
    {
        private static By botonLupa = By.Name("INICIO");
        private static By btnIniciarSesion = By.XPath("//nav//a[.='Iniciar sesión']");
        private static By btnSiguiente = By.Id("idSIButton9");
        private static By btnBandejaEntrada = By.XPath("//*/span[@class='_16aPYHYIOVxzNYTA4BGnwS NJVykX0WljoRws2qTYI5G']");

        public static By BotonLupa() { return botonLupa; }
        public static By BtnIniciarSesion() { return btnIniciarSesion; }
        public static By BtnSiguiente() { return btnSiguiente; }
        public static By BtnBandejaEntrada() { return btnBandejaEntrada; }
    }
}
