using System;

namespace DelegatesBeregner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Beregner(Int32.MaxValue, 1, Plus));

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }


        public delegate int Beregn(int a, int b);

        public static int Beregner(int a, int b, Beregn c)
        {
            return (c?.Invoke(a, b)).GetValueOrDefault();
        }


        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }
    }


}
