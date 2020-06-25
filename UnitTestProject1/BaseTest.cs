namespace UnitTestProject1
{
    using NUnit.Framework;
    using System;

    public abstract class BaseTest
    {
        private readonly string baseURL = "https://www.google.com.ar";

        [SetUp]
        public void SetupTest()
        {
            Driver.Init();
            Driver.GetIntance().Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            Driver.GetIntance().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            Driver.GetIntance().Manage().Window.Maximize();
            Driver.GetIntance().Navigate().GoToUrl(baseURL);
        }

        [TearDown]
        public void TeardownTest()
        {
            String statusFinal;
            var currentContext = TestContext.CurrentContext;
            var testName = currentContext.Test.Name;

            statusFinal = currentContext.Result.Outcome.Status.ToString().Equals("Passed") ?
                                                                                 "CORRECTA" :
                                                                                 "INCORRECTA";

            try
            {
                if (statusFinal.Equals("INCORRECTA"))
                {
                    string filename = Driver.TaskPrintFull();
                    TestContext.AddTestAttachment(filename);
                    XLog.Message($"{"Captura del estado final antes de cerrar el driver. OK"}");
                }
            }
            catch (Exception e)
            {
                XLog.Message($"'{"Falló la captura del estado final antes de cerrar el driver. KO"}'" +
                             $"\r\n'{XLog.DateAndHours()} ''{e.Message}'");
            }

            XLog.Message($"El caso de Prueba '{testName}' termino de manera '{statusFinal}'");

            if (statusFinal.Equals("INCORRECTA")) XLog.Message(TestContext.CurrentContext.Result.Message);

            XLog.WriteLog();

            TestContext.AddTestAttachment(XLog.PathLog, testName);

            if (Driver.GetIntance() != null)
            {
                Driver.GetIntance().Quit();
                Driver.GetIntance().Dispose();
            }
        }
    }
}