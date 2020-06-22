namespace UnitTestProject1.Actions
{
    using OpenQA.Selenium;

    class Click
    {
        public static void On(By locator)
        {
            Element.On(locator).Click();        
        }
    }
}
