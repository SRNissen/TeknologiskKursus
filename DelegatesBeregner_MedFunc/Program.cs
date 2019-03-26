using System;

namespace DelegatesBeregner_MedFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Beregner(7, 6, Plus));
            Console.WriteLine(Beregner(5, 4, Minus));
            Console.WriteLine(Beregner(3, 2, Gange));
            Console.WriteLine(Beregner(1, 0, Dividere));


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public static int Beregner(int a, int b, Func<int, int, int> c)
        {
            try
            {
                return (c?.Invoke(a, b)).GetValueOrDefault();
            }
            catch (Exception)
            {
                return 0;
            }
            
        }


        public static int Plus(int a, int b)
        {
            try
            {
                return (a + b);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int Minus(int a, int b)
        {
            try
            {
                return (a - b);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int Gange(int a, int b)
        {
            try
            {
                return (a * b);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int Dividere(int a, int b)
        {
            try
            {
                return (a / b);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
