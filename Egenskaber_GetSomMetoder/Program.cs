using System;

namespace Egenskaber_GetSomMetoder
{
    class Program
    {
        static void Main(string[] args)
        {

            var trekant = new Trekant(4, 3);
            Console.WriteLine(trekant.Areal);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
