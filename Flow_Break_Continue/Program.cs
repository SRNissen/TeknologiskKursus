using System;

namespace Flow_Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(true)
            {
                if(i%3 == 0)
                {
                    Console.WriteLine(i);
                }

                i++;

                if(i>15)
                {
                    break;
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
