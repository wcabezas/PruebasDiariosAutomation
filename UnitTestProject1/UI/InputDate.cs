

namespace UnitTestProject1.UI
{
    using OpenQA.Selenium;

    public static class InputDate
    {
        private static By buscadorClarin = By.Id("gsc-i-id1");
        private static By buscadorGoogle = By.Name("q");
        private static By inputMail = By.Id("i0116");
        private static By inputPassWord = By.Name("passwd");
        private static By destinatario = By.XPath("//*/input[@class='ms-BasePicker-input pickerInput_cf204fb8']");
        private static By asunto = By.CssSelector("input[id^='TextField']");
        private static By mensaje = By.CssSelector("div[aria-label='Cuerpo del mensaje']");
        private static By buscadorOutlook = By.XPath("//input[@placeholder='Buscar']");


        public static By BuscadorClarin() { return buscadorClarin; }
        public static By BuscadorGoogle() { return buscadorGoogle; }
        public static By InputMail() { return inputMail; }
        public static By InputPassWord() { return inputPassWord; }
        public static By Destinatario() { return destinatario; }
        public static By Asunto() { return asunto; }
        public static By Mensaje() { return mensaje; }
        public static By BuscadorOutlook() { return buscadorOutlook; }
    }
}
