/*
 
Opret en DateTime d1, tildel den maskintid og udskriv den
Læg nu 10 dage til (d1 = d1.AddDays(10)) og udskriv
Læg nu 20 minutter til og udskriv
Træk en måned fra (brug addMonths(-1)) og udskriv
Prøv at oprette to DateTime-variabler (d2 og d3), træk dem fra hinanden og udskriv antal dage
Opret et TimeSpan t2, initialiser til 16:00:00 timer og skriv ud
Opret et TimeSpan t3, initialiser til kl. 00:30:00 minutter og skriv ud
Opret et TimeSpan t4, tildel den værdien af t2-t3 og skriv ud
Opret et TimeSpan t5, tildel den værdien af t2+t3 og skriv ud
 
 */

using System;

namespace BrugAfVariabler_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {

            var d1 = DateTime.Now;
            d1 = d1.AddDays(10);
            Console.WriteLine(d1);
            d1 = d1.AddMinutes(20);
            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);
            var d2 = DateTime.Now;
            var d3 = d1;
            Console.WriteLine((d2-d3).Days);
            var t2 = TimeSpan.FromHours(16);
            Console.WriteLine(t2);
            var t3 = TimeSpan.FromMinutes(30);
            Console.WriteLine(t3);
            var t4 = t2 - t3;
            Console.WriteLine(t4);
            var t5 = t2 + t3;
            Console.WriteLine(t5);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
