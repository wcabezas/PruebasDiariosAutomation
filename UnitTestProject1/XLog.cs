namespace UnitTestProject1
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    public static class XLog
    {
        private static String message = "",
                              lastLog = "",
                              pathLog = "";

        public static string LastLog { get => lastLog; }
        public static string PathLog { get => pathLog; }

        public static void Message(string linea)
        {
            message += DateAndHours() + linea + "\r\n";
        }
        public static String DateAndHours()
        {
            DateTimeFormatInfo EnFormat = new CultureInfo("en-US", false).DateTimeFormat;
            DateTime time = DateTime.Now;
            string s = time.ToString("ddd MMMM dd - HH:mm:ss  ", EnFormat);
            return Regex.Replace(s, @"\.", string.Empty);
        }
        public static void WriteLog()
        {
            string filename;

            filename = pathLog = NameLog();

            StreamWriter log = new StreamWriter(filename, true, Encoding.UTF8);

            log.Write(message);
            log.Close();
        }

        public static String ChangeChar(String cadena, String charOut1, String charOut2)
        {
            while (cadena.Contains(charOut1))
            {
                cadena = cadena.Replace(charOut1, charOut2);
            }
            return cadena;
        }
        private static string NameLog()
        {
            string filename = string.Format("LOG_{0}_{1}.txt",
                                           NUnit.Framework.TestContext.CurrentContext.Test.Name,
                                           DateTime.Now);

            filename = ChangeChar(filename, "/", "-");
            filename = ChangeChar(filename, ":", "");
            filename = ChangeChar(filename, " ", "_");

            lastLog = filename;

            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                filename);
        }
    }
}
