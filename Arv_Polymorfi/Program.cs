using System;
using System.Collections.Generic;

namespace Arv_Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Dyr> dyr = new List<Dyr>
            {
                new Kat() { Navn = "Mis" },
                new Hund() { Navn = "Busser" },
                new Kat() { Navn = "Kitty" },
                new Hund() { Navn = "Doggy" }
            };

            foreach (var kæledyr in dyr)
            {
                kæledyr.SigNoget();
            }

            Console.WriteLine("---------------------------------------------------------------------");

            List<Dyr> tilfældigeDyr = new List<Dyr>();
            tilfældigeDyr.Add(Dyr.TilfældigtDyr());
            tilfældigeDyr.Add(Dyr.TilfældigtDyr());
            tilfældigeDyr.Add(Dyr.TilfældigtDyr());
            tilfældigeDyr.Add(Dyr.TilfældigtDyr());
            tilfældigeDyr.Add(Dyr.TilfældigtDyr());

            foreach (var rando in tilfældigeDyr)
            {
                rando.SigNoget();
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

}
