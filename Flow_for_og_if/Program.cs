using System;
using System.Collections.Generic;

namespace Flow_for_og_if
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> outlist = new List<int>();

            for(int i=1; i<11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    outlist.Add(i * j);
                }
            }

            for (int k = 0; k < 100; k++)
            {
                string output = System.Convert.ToString(outlist[k]);

                output = output.PadLeft(4);

                if (outlist[k]>50)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.Write($" {output}");
                Console.ForegroundColor = ConsoleColor.White;

                if ((k+1)%10 == 0)
                {
                    Console.Write("\n");
                }
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
