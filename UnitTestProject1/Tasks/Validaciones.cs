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
    }
}
