namespace UnitTestProject1.Actions
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public static class Click
    {
        public static void On(By locator)
        {
            Element.On(locator).Click();        
        }

        public static void ActionClick(By locator)
        {
            IWebElement button = Driver.GetIntance().FindElement(locator);
            Actions action = new Actions(Driver.GetIntance());
            action.Click(button).Perform();
        }
    }
}
