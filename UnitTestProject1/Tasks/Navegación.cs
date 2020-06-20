namespace UnitTestProject1.Tasks
{
    using System;
    using UnitTestProject1.Actions;
    using UnitTestProject1.UI;
    using Tests;

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
            Driver.GetIntance().Navigate().GoToUrl(url);
        }

        public static void BusquedaEnGoogle(String texto)
        {
            Text.On(InputDate.BuscadorGoogle(), texto);
        }
    }
}
