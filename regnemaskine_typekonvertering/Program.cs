/*
 
Start en ny tom konsol applikation der kan lægge to tal sammen:

Brug Console.WriteLine til at skrive "Indtast tal 1"
Brug Console.ReadLine til at hente det brugeren indtaster, og tildel det til en string-variabel (tal1)
Brug Console.WriteLine til at skrive "Indtast tal 2"
Brug Console.ReadLine til at hente det brugeren indtaster, og tildel det til en string-variabel (tal2)
Konverter tal1 og tal2 til to double-variabler (t1 og t2) - brug System.Convert
Læg t1 og t2 sammen og tildel resulat til en ny double variabel
Udskriv resultat formateret med to decimaler og tusindtal seperator
Prøv også at

taste et "forkert" tal ind (eksempelvis 10a) - hvad sker der så? (der burde ske en fejl - prøv både med og uden debugger)
bruge både . og , som decimaltegn - hvad sker der så? (konvertering benytter den kultur maskinen nu har)
 
 */

using System;
using System.Collections.Generic;
using System.Globalization;

namespace regnemaskine_typekonvertering
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Indtast tal 1");
            string buffer1 = Console.ReadLine();

            Console.WriteLine("Indtast tal 2");
            string buffer2 = Console.ReadLine();

            double result = CultureFreeConversion(buffer1) + CultureFreeConversion(buffer2);

            Console.WriteLine(result.ToString("N2", CultureInfo.InvariantCulture));

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static double CultureFreeConversion(string input)
        {

            int period = input.LastIndexOf('.');
            int comma = input.LastIndexOf(',');

            List<int> commaList = new List<int>();
            List<int> periodList = new List<int>();

            for (int i = 0; i<input.Length; i++)
            {
                if (input[i] == '.')
                {
                    periodList.Add(i);
                }
                if (input[i] == ',')
                {
                    commaList.Add(i);
                }
            }

            if(commaList.Count==0 && periodList.Count == 0)
            {
                return System.Convert.ToDouble(input);
            }

            return 0;
        }
    }
}
