namespace UnitTestProject1.Tasks
{
    using System;
    using UnitTestProject1.Actions;
    using UnitTestProject1.UI;
    

    class Navegación
    {
        public static void buscar(String cadena)
        {
            try
            {
                Click.On(Button.BotonLupa());
                Text.On(Button.BotonLupa(), cadena);
                XLog.Message("Buscar en Clarín, Ok");

            }
            catch (System.Exception)
            {
                throw new System.Exception("Falló la busqueda de " + "'" + cadena + "' en Clarín" );
            }
            Driver.TaskPrint();
        }

        public static void ClickFueraDelPopUp()
        {
            try
            {
                Click.On(Texto.FechaDeHoyClarin());
                XLog.Message("Clic fuera del popup, OK");
            }
            catch (System.Exception)
            {

                throw new System.Exception("No se pudo hacer click fuera del popup");
            }
            Driver.TaskPrint();
        }

        public static void IrAUrl(String url)
        {
            try
            {
                Driver.GetIntance().Navigate().GoToUrl(url);
                XLog.Message("Ir a " + url + ", OK");
            }
            catch (System.Exception)
            {
                XLog.Message("Ir a " + url + ", KO");
                throw new System.Exception("No se pudo ir a " + url);
            }
            Driver.TaskPrint();
        }

        public static void BusquedaEnGoogle(String texto)
        {
            try
            {
                Text.On(InputDate.BuscadorGoogle(), texto);
                XLog.Message("Busqueda de " + texto + " en Google, OK");
            }
            catch (System.Exception)
            {
                XLog.Message("Busqueda de " + texto + " en Google, KO");
                throw new System.Exception("Fallo la busqueda en google.");
            }
            Driver.TaskPrint();
        }

        public static void LogInOutlook(String mail, String password)
        {
            try
            {
                Click.On(Texto.ResultadoOutlook());
                Click.On(Button.BtnIniciarSesion());
                Enter.EnviarTexto(InputDate.InputMail(), mail);
                Click.On(Button.BtnSiguiente());
                Enter.EnviarTexto(InputDate.InputPassWord(), password);
                Click.On(Button.BtnSiguiente());
                XLog.Message("LogIn en Outlook, OK");
            }
            catch (System.Exception)
            {
                XLog.Message("LogIn en Outlook, KO");
                throw new System.Exception("Fallo LogIn en Outlook");
            }
            Driver.TaskPrint();
        }

    }

}
