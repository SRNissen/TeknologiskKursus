using System;
using System.IO;

namespace Metoder_Statisk
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileString = "c:\\temp\\test.txt";

            if (File.Exists(fileString))
            {
                var input = File.ReadAllText(fileString);

                var fil = new FileInfo(fileString);
                Console.WriteLine(input);
                Console.WriteLine(fil.LastAccessTime);
                Console.WriteLine(fil.Extension);

            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
