using System;

namespace Delegates_HeltGrundlæggende
{
    class Program
    {
        static void Main(string[] args)
        {

            MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);
            f1?.Invoke("test1");

            MinDelegate1 f2 = MinSkrivTilConsole;
            f2("test2");

            MinDelegate1 f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("test3");

            f1 = f1 - MinSkrivTilConsole;
            f1 = f1 - MinSkrivTilConsole; //Despite being empty at this point, you can still """remove""" functions from the delegate, this does not throw an exception.
            f1 = f1 - MinSkrivTilConsole;


            f2 -= MinSkrivTilConsole;

            f3 -= MinSkrivTilConsole;
            f3 -= Console.WriteLine;

            f1("test4"); //Using a null delegate, however, will throw an exception.
            f2("test5");
            f3("test6");



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }

        public delegate void MinDelegate1(string input);
    }
}
