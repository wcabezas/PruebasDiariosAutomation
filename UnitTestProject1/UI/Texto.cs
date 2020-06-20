namespace UnitTestProject1.UI
{
    using OpenQA.Selenium;
    using System;

    public static class Texto
    {
       // private static String tituloOutlook = "Outlook – free personal email and calendar from Microsoft";
        private static By InputGoogle { get; set; } = By.XPath("//*");
        private static By fechaDeHoyClarin = By.XPath("//div/*//div[@class=\"dateTime pull - right\"]");
        private static By resultadoOutlook = By.XPath("//div/*//h3[contains(text(),'Outlook – free personal email and calendar from Microsoft')]");

        public static  By FechaDeHoyClarin() { return fechaDeHoyClarin; }
        public static  By ResultadoOutlook() { return resultadoOutlook; } 
        
    }
}
