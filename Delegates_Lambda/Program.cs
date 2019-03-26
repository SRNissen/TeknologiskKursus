using System;
using System.Collections.Generic;

namespace Delegates_Lambda
{
    class Program
    {
        public static bool Find51(int a)
        {
            return a == 51;
        }

        public static void Write(int a)
        {
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };

            int index = a.FindIndex(Find51);
            Console.WriteLine(index);
            a.ForEach(Write);
             
            Console.WriteLine("------------------------------");

            int index2 = a.FindIndex(x => x == 51);
            Console.WriteLine(index2);
            a.ForEach(x => Console.WriteLine(x));

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
