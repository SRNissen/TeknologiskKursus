using System;

namespace Klasser_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            AppSettings appSettings = AppSettings.HentAppSettings();
            appSettings.AppId = 10;
            Console.WriteLine(appSettings.AppId);   // 10
            appSettings = AppSettings.HentAppSettings();
            Console.WriteLine(appSettings.AppId);   // 10

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
