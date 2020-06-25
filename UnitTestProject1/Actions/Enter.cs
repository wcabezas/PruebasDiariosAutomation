

namespace UnitTestProject1.Actions
{
    using OpenQA.Selenium;

    public static class Enter
    {
        public static void EnviarTexto(By locator, string texto)
        {
            Element.On(locator).Clear();
            Element.On(locator).SendKeys(texto);
            
        }

        public static void KeyEnter(By locator)
        {
            Element.On(locator).SendKeys(Keys.Enter) ;
            
        }

        public static void KeyTab(By locator)
        {
            Element.On(locator).SendKeys(Keys.Tab);

        }
    }
}
