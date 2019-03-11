using System;

namespace Egenskaber_KompletteEgenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            var vare = new Vare("Kop", 22);
            Console.WriteLine(vare.PrisMedMoms());
            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

}
