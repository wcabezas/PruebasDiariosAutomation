

namespace UnitTestProject1.UI
{
    using OpenQA.Selenium;

    public static class InputDate
    {
        private static By buscadorClarin = By.Id("gsc-i-id1");
        private static By buscadorGoogle = By.Name("q");


        public static By BuscadorClarin() { return buscadorClarin; }
        public static By BuscadorGoogle() { return buscadorGoogle; }
    }
}
