namespace UnitTestProject1
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    
    class Driver
    {
        private static string browser = "Chrome";
        private static IWebDriver driver;

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

    }
}
