using System;

namespace Delegates_Log
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine m = new Machine { Log = Console.WriteLine };
            m.Start();
            System.Threading.Thread.Sleep(1000);
            m.Stop();


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Machine
    {
        public Action<string> Log { get; set; }

        public void Start()
        {
            Log($"Start: {System.Convert.ToString(System.DateTime.Now)}");
        }

        public void Stop()
        {
            Log($"Stop: {System.Convert.ToString(System.DateTime.Now)}");
        }
    }
}
