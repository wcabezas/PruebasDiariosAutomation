namespace UnitTestProject1
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using NUnit.Framework;
    class Driver
    {
        private static string    browser = "Chrome";
        private static IWebDriver driver;
        static int indice = 1;

        public static IWebDriver GetIntance()
        {
            return driver;
        }

        public static void Init()
        {
            switch (browser)
            {
                case "Chrome":
                    var options = new ChromeOptions();
                    options.AddArgument("--no-sandbox");
                    driver =new ChromeDriver(options);
                    break;
                case "IE":
                    break;
                case "Firefox":
                    break;
            }

        }

        public static string TakeFullScreenshot()
        {
            string filename = System.IO.Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            string.Format(indice + "-" +
                          TestContext.CurrentContext.Test.Name +
                          "-" +
                          "{0}.jpg", Guid.NewGuid().ToString()));
            Screenshot screenshot = ((ITakesScreenshot)Driver.GetIntance()).GetScreenshot();
            screenshot.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
            indice++;
            return filename;
        }

        public static void TaskPrint()
        {
            try
            {
                TestContext.AddTestAttachment(TakeFullScreenshot(), TestContext.CurrentContext.Test.Name);
            }
            catch (Exception)
            {
                Console.WriteLine("Hubo un incoveniente en la captunra.");
            }
        }

    }
}
