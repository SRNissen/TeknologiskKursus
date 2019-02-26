using System;

namespace Metoder_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Beregn(1,2));
            Console.WriteLine(Beregn(1,2,3));
            Console.WriteLine(Beregn(1,2,3,5));


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public static int Beregn(int a, int b)
        {
            return Beregn(a, b, 0);
        }

        public static int Beregn(int a, int b, int c)
        {
            return Beregn(a, b, c, 0);
        }

        public static int Beregn(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }
}
