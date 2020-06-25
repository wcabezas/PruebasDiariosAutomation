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
                WaitUntil.ElementIsPresent(Button.BtnBandejaEntrada(), 380);
                return Element.On(Button.BtnBandejaEntrada()).Text.Contains("Bandeja de entrada");
            }
            catch (System.Exception)
            {
                XLog.Message("Validacion de Boton Bandeja de entrada, KO");
                throw new System.Exception("Fallo la validacion del boton Bandejade entrada");
            }

        }

        public static bool TextoDeMailEliminado()
        {
            try
            {
            
                XLog.Message("Validación de mail eliminado, OK");
                return Element.On(Texto.TextoMailEliminado()).Text.Contains("Se ha eliminado");
            }
            catch (System.Exception)
            {
                XLog.Message("Validación de mail eliminado, KO");
                throw new System.Exception("Fallo validación de eliminación de mail");
            }
        }

        public static bool ElMensajeFueEnviado()
        {
            try
            {
                XLog.Message("Validacion del mensaje enviado, OK");
                return Element.On(Texto.MailEnviadoDePrueba()).Text.Contains(DatosDePrueba.asuntoMailPrueba);
            }
            catch (System.Exception)
            {
                XLog.Message("Validacion del mensaje enviado, KO");
                throw new System.Exception("Falló la validación del mail enviado");
            }            
        }
    }
}