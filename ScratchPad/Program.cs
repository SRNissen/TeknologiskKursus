using System;

namespace ScratchPad
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 10; i-->0;)
            {
                Console.WriteLine(i);
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
