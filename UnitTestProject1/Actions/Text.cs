namespace UnitTestProject1.Actions
{
    using OpenQA.Selenium;
    using System;

    class Text
    {
        public static void On(By locator, String text)
        {
            Enter.EnviarTexto(locator, text);
            Enter.KeyEnter(locator, text);
        }
    }
}
