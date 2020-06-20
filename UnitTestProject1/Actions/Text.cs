namespace UnitTestProject1.Actions
{
    using OpenQA.Selenium;
    using System;

    class Text
    {
        public static void On(By locator, String text)
        {
            Driver.GetIntance().FindElement(locator).SendKeys(text);
            Driver.GetIntance().FindElement(locator).SendKeys(Keys.Enter);
        }
    }
}
