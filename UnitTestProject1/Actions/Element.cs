

namespace UnitTestProject1.Actions
{
    using OpenQA.Selenium;

    public static class Element
    {
        public static IWebElement On(By locator)
        {
            WaitUntil.ElementIsVisible(locator);
            return Driver.GetIntance().FindElement(locator);
        } 
    }
}
