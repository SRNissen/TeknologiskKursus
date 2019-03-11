using System;

namespace Hukommelse_Struct_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var S1 = new SPerson();
            var S2 = new SPerson();
            S1.Id = 1;
            S2.Id = 2;
            Console.WriteLine("");
            Console.WriteLine($"Initial          : S1.Id: {S1.Id}; S2.Id: {S2.Id}");
            S1 = S2;
            Console.WriteLine($"After 1=2        : S1.Id: {S1.Id}; S2.Id: {S2.Id}");
            S1.Id = 3;
            Console.WriteLine($"After 1.Id change: S1.Id: {S1.Id}; S2.Id: {S2.Id}");

            var C1 = new CPerson();
            var C2 = new CPerson();
            C1.Id = 1;
            C2.Id = 2;
            Console.WriteLine("");
            Console.WriteLine($"Initial          : C1.Id: {C1.Id}; C2.Id: {C2.Id}");
            C1 = C2;
            Console.WriteLine($"After 1=2        : C1.Id: {C1.Id}; C2.Id: {C2.Id}");
            C1.Id = 3;
            Console.WriteLine($"After 1.Id change: C1.Id: {C1.Id}; C2.Id: {C2.Id}");



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        struct SPerson
        {
            public int Id;
        }

        class CPerson
        {
            public int Id;
        }
    }
}
