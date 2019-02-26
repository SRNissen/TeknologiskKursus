using System;

namespace Variabler_Struct_Enum
{
    class Program
    {
        static void Main(string[] args)
        {

            SpilleKort s1 = new SpilleKort
            {
                Værdi = 2,
                Kulør = SpilleKort.EKulør.Spar
            };
            Console.WriteLine($"{s1.Kulør} {s1.Værdi}");

            SpilleKort s2 = new SpilleKort
            {
                Værdi = 10,
                Kulør = SpilleKort.EKulør.Hjerter
            };
            Console.WriteLine($"{s2.Kulør} {s2.Værdi}");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        

    }

    struct SpilleKort
    {
        public int Værdi;
        public EKulør Kulør;

        public enum EKulør
        {
            Hjerter,
            Ruder,
            Spar,
            Klør
        }
    }
}
