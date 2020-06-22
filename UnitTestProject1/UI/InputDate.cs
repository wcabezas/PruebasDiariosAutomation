

namespace UnitTestProject1.UI
{
    using OpenQA.Selenium;

    public static class InputDate
    {
        private static By buscadorClarin = By.Id("gsc-i-id1");
        private static By buscadorGoogle = By.Name("q");
        private static By inputMail = By.Id("i0116");
        private static By inputPassWord = By.Name("passwd");


        public static By BuscadorClarin() { return buscadorClarin; }
        public static By BuscadorGoogle() { return buscadorGoogle; }
        public static By InputMail() { return inputMail; }
        public static By InputPassWord() { return inputPassWord; }
    }
}
