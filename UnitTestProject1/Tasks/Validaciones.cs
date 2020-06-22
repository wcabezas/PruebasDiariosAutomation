namespace UnitTestProject1.Tasks
{
    using UnitTestProject1.Actions;
    using UnitTestProject1.UI;
    using OpenQA.Selenium;
    public static class Validaciones
    {
        public static bool Texto_(string cadena)
        {
            return false;
        }

        public static bool BuscadorLargoVisible()
        {
            return Driver.GetIntance().FindElement(InputDate.BuscadorClarin()).Enabled &&
                Driver.GetIntance().FindElement(InputDate.BuscadorClarin()).Displayed;
        }

        public static bool TituloOutlookVisible(string text)
        {
            return Driver.GetIntance().FindElement(Texto.ResultadoOutlook()).Text.Contains(text);
        }

        public static bool SeMuestraBotonBandejaDeEntrada()
        {
            try
            {
                XLog.Message("Validacion de Boton Bandeja de entrada, OK");
                System.Console.WriteLine(Element.On(Button.BtnBandejaEntrada()).Text);
                WaitUntil.ElementIsPresent(Button.BtnBandejaEntrada(), 380);
                return Element.On(Button.BtnBandejaEntrada()).Text.Contains("Bandeja de entrada");
            }
            catch (System.Exception)
            {
                XLog.Message("Validacion de Boton Bandeja de entrada, KO");
                throw new System.Exception("Fallo la validacion del boton Bandejade entrada");
            }

        }
    }
}
