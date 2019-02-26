/*
 Du skal skabe en tom konsol app der på konsol skal udskrive tal fra 1 til 10
 men du må ikke bruge en løkke struktur (for, foreach, do, while mv).

Du skal i stedet skabe en metode der kalder sig selv et givet antal gange og der opskriver og udskriver.
*/

using System;

namespace Metoder_rekursiv
{
    class Program
    {
        static void Main(string[] args)
        {

            recurse();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public static void recurse(int a = 1)
        {
            if(a < 11)
            {
                Console.WriteLine(a);
                a++;
                recurse(a);
            }
        }
    }
}
