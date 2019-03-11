using System;

namespace Klasser_SimpelKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Person A = new Person();
            Person B = new Person("HrOgFru", "Danmark", 960);

            Console.WriteLine($"{B.FuldtNavn()} er {B.Alder()} år gammel");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
