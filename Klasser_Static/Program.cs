using System;

namespace Klasser_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine(Beregninger.LægSammen(7, 5));
                Console.WriteLine(Beregninger.TrækFra(7,5));

                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
