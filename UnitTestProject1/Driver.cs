namespace UnitTestProject1
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using NUnit.Framework;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public static class Driver
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

        public static string TaskPrintFull()
        {
            string filename = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, string.Format($"T{indice}" + TestContext.CurrentContext.Test.Name + "-" + "{0}.jpg", Guid.NewGuid().ToString()));

            Bitmap bmp = new Bitmap(
                Screen.PrimaryScreen.Bounds.Width,
                Screen.PrimaryScreen.Bounds.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                bmp.Save(filename);
            }
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
