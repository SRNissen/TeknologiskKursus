using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Filewatcher
{
    class Program
    {
        static void Main(string[] args)
        {



            System.IO.FileSystemWatcher fsw = new System.IO.FileSystemWatcher("c:\\temp");
            
            fsw.Created += (s, e) => { Console.WriteLine($"File \"{e.Name}\" was created"); };
            fsw.Changed += Fsw_Changed;
            fsw.Deleted += (s, e) => { Console.WriteLine($"File \"{e.Name}\" was deleted"); };
            fsw.EnableRaisingEvents = true;


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        private static void Fsw_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine($"File \"{e.Name}\" was modified");
        }
    }
}
