using System;

namespace Variabler_Struct
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Vare v1 = new Vare();

            v1.Id = 1;
            v1.Navn = "Vare #1";
            v1.Beskrivelse = "Min beskrivelser til #1";
            v1.Pris = 100;
            Console.WriteLine($"{v1.Navn} koster {v1.Pris:N2}");

            Vare v2 = new Vare(2, "Vare #2", "Min beskrivelse til #2", 200);
            Console.WriteLine($"{v2.Navn} koster {v2.Pris:N2}");

            Vare v2Kopi = v2;
            Console.WriteLine($"{v2Kopi.Navn} koster {v2Kopi.Pris:N2}");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
