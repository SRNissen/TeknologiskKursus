using System;
using System.Collections.Generic;

namespace Arv_Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Terning> terninger = new List<Terning>();
            Console.WriteLine("Initializing normal dice with values blank and zero-through-seven");
            terninger.Add(new Terning());
            terninger.Add(new Terning(0));
            terninger.Add(new Terning(1));
            terninger.Add(new Terning(2));
            terninger.Add(new Terning(3));
            terninger.Add(new Terning(4));
            terninger.Add(new Terning(5));
            terninger.Add(new Terning(6));
            terninger.Add(new Terning(7));
            foreach (var terning in terninger)
            {
                terning.Write();
            }

            List<Terning> ludos = new List<Terning>();
            Console.WriteLine("Initializing Ludo dice with values blank; zero-through-seven; S; G;");
            ludos.Add(new LudoTerning());
            ludos.Add(new LudoTerning(0));
            ludos.Add(new LudoTerning(1));
            ludos.Add(new LudoTerning(2));
            ludos.Add(new LudoTerning(3));
            ludos.Add(new LudoTerning(4));
            ludos.Add(new LudoTerning(5));
            ludos.Add(new LudoTerning(6));
            ludos.Add(new LudoTerning(7));
            ludos.Add(new LudoTerning('S'));
            ludos.Add(new LudoTerning('G'));
            foreach (var ludo in ludos)
            {
                ludo.Write();
            }

            Console.WriteLine("Shaking each die");
            foreach (var terning in terninger)
            {
                terning.Shake();
                terning.Write();
            }
            Console.WriteLine("Shaking each ludo die");
            foreach (var die in ludos)
            {
                die.Shake();
                die.Write();
            }



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
