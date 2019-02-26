/*
Du skal skabe en tom konsol app med følgende små metoder:

Int LægSammen(int a, int b)
    Lægger a og b sammen og returnere resultatet
double BeregnAreal(int radius)
    Beregner og returnere arealet af en cirkel (radius * radius * pi (se System.Math.PI) )
Udskriv(string txt)
    Udskriver txt på konsol (med Console.WriteLine)
 */


using System;

namespace Metoder_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res); // 7
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2); // 78.53…
            Udskriv("Dette er en test"); // Dette er en test

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public static int LægSammen(int a, int b)
        {
            return a + b;
        }

        public static double BeregnAreal(int radius)
        {
            return System.Math.PI * System.Math.Pow((double)radius, 2);
        }

        public static void Udskriv(string text)
        {
            Console.WriteLine(text);
        }
    }
}
