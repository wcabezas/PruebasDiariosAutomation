namespace UnitTestProject1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public abstract class BaseTest
    {
        private string baseURL = "https://www.google.com.ar";

        [TestInitialize]
        public void SetupTest()
        {
            Driver.Init();
            Driver.GetIntance().Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            Driver.GetIntance().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            Driver.GetIntance().Manage().Window.Maximize();
            Driver.GetIntance().Navigate().GoToUrl(baseURL);
        }

        [TestCleanup]
        public void TeardownTest()
        {
            if (Driver.GetIntance() != null)
            {
                Driver.GetIntance().Quit();
                Driver.GetIntance().Dispose();
            }
        }
    }
}