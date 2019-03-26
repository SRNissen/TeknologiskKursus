using System;
using System.Collections.Generic;

namespace Delegates_Lambda
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };

            bool Find51(int x)
            {
                return x == 51;
            }
            void Write(int x)
            {
                Console.WriteLine(x);
            }
            int index0 = a.FindIndex(Find51);
            Console.WriteLine(index0);
            a.ForEach(Write);

            Console.WriteLine("------------------------------");

            int index1 = a.FindIndex((int x) => { return x == 51; });
            Console.WriteLine(index1);
            a.ForEach((int x) => { Console.WriteLine(x); });

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
