using System;

namespace metoder_rekursiv_adv
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = "C:\\Users\\admin\\source\\repos\\TeknologiskKursus";
            Console.WriteLine($"Current path: {path}");
            Recurse(path);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public static void Recurse(string path)
        {
            var files = System.IO.Directory.GetFiles(path);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = System.IO.Directory.GetDirectories(path);
            foreach(var directory in directories)
            {
                Recurse(directory);
            }
        }
    }
}
