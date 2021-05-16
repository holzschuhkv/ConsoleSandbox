using System;
using System.Configuration;

namespace TestApplicationConsole.Basics
{
    class ReadingAppConfig
    {
        protected void ReadAppConfig()
        {
            string appSetingsKey1 = ConfigurationManager.AppSettings["Key1"];
            string appSetingsKey2 = ConfigurationManager.AppSettings["Key2"];

            Console.WriteLine($"Key 1 = {appSetingsKey1}{Environment.NewLine}Key 2 = {appSetingsKey2}");
        }
    }
}
