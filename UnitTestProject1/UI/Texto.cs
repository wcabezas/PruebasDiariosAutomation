namespace UnitTestProject1.UI
{
    using OpenQA.Selenium;
   
    public static class Texto
    {
        private static By InputGoogle { get; set; } = By.XPath("//*");
        private static By fechaDeHoyClarin = By.XPath("//div/*//div[@class=\"dateTime pull - right\"]");
        private static By resultadoOutlook = By.XPath("//div/*//h3[contains(text(),'Outlook – free personal email and calendar from Microsoft')]");
        private static By textoMailEliminado = By.XPath("//div/*//div[@class='_3xqEuTlsJbTQdiBbqhDlEy']");
        private static By mailEnviadoDePrueba = By.XPath("//*/div[@class='_1xP-XmXM1GGHpRKCCeOKjP']/*//span[.='"+DatosDePrueba.asuntoMailPrueba+"']");
        private static By elementosEnviados = By.CssSelector("#app > div > div._3KAPMPOz8KsW24ooeUflK2 > div._2jR8Yc0t2ByBbcz_HIGqZ4 > div._1TpU2KF6f_EeQiytBaYj8I > div._3mBjlqTqXMUiRuuWRKCPtX.css-40 > div._1jw6v9zFEgnOiXShpU1qqM > div > div._12kNe1_3Wqt-EZZpg5gAm1.css-177 > div.threeColConversationViewSenderImageOn.R13rCAdCs2xraNrPX7bVq > div > div._35m9jXzKfsdYcCKb26_oYU.XOTQB6rfVy1iLgo3kqj8M.threeColConversationViewSenderImageOn > span");

        public static  By FechaDeHoyClarin() { return fechaDeHoyClarin; }
        public static  By ResultadoOutlook() { return resultadoOutlook; } 
        public static  By TextoMailEliminado() { return textoMailEliminado; }
        public static  By MailEnviadoDePrueba() { return mailEnviadoDePrueba; }
        public static  By ElementosEnviados() { return elementosEnviados; }
        
    }
}
