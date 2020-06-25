namespace UnitTestProject1.Tasks
{
    using System;
    using UnitTestProject1.Actions;
    using UnitTestProject1.UI;
    using OpenQA.Selenium;

    public static class Navegación
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

        public static void EliminarSpam()
        {
            try
            {
                Click.On(Button.BtnCorreoNoDeseado());
                Click.On(Button.BtnSeleccionarPrimerMail());
                Click.On(Button.BtnEliminarMail());
                XLog.Message("Eliminar Mail de Spam, OK");
            }
            catch (Exception)
            {
                XLog.Message("Eliminar Mail de Spam, KO");
                throw new Exception("Fallo eliminar mail de Spam");
            }
            Driver.TaskPrint();
        }

        public static void EnviarMailOutlook() 
        {
            try
            {
                
                Click.On(Button.BtnMensajeNuevo());
                Enter.EnviarTexto(InputDate.Destinatario(),DatosDePrueba.mailDePrueba);
                System.Threading.Thread.Sleep(4000);
                Click.ActionClick(InputDate.Mensaje());
                Enter.EnviarTexto(InputDate.Asunto(), DatosDePrueba.asuntoMailPrueba);
                Enter.EnviarTexto(InputDate.Mensaje(), DatosDePrueba.mensajeDePrueba);
                Click.On(Button.BtnEnviarMensaje());

                XLog.Message("Enviar mail desde outlook, OK");                
            }
            catch (Exception)
            {
                XLog.Message("Enviar mail desde outlook, KO");
                throw new Exception("Fallo el envío de mail desde outlook");
            }
            Driver.TaskPrint();
        }

        public static void IrAMensajesEnviados()
        {
            try
            {
                System.Threading.Thread.Sleep(10000);
                Click.On(Button.BtnMensajesEnviados());
                XLog.Message("Ir a mensajes enviados, OK");
            }
            catch (Exception)
            {
                XLog.Message("Ir a mensajes enviados, KO");
                throw new Exception("Fallo ir a mensajes enviados");
            }
            Driver.TaskPrint();
        }

        public static void BuscarMensaje()
        {
            try
            {
                Enter.EnviarTexto(InputDate.BuscadorOutlook(), DatosDePrueba.asuntoMailPrueba);
                Click.On(Button.BtnLupaOutlook());
                XLog.Message("Busqueda de mensaje, OK");
            }
            catch (Exception)
            {
                XLog.Message("Busqueda de mensaje, KO");
                throw new Exception("Fallo la busqueda del mensaje");
            }
            Driver.TaskPrint();
        }

        public static void EliminarMensaje()
        {
            try
            {
                Click.On(Texto.MailEnviadoDePrueba());
                Click.On(Button.BtnEliminarMail());
                XLog.Message("Eliminar mensaje, OK");
            }
            catch (Exception)
            {
                XLog.Message("Eliminar mensaje, KO");
                throw new Exception("Fallo la eliminacion del mensaje");
            }
            Driver.TaskPrint();
        }
    }

}
