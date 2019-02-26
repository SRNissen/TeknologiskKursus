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

            //Hvis der er mere end én instans af noget, så er det ikke en decimal-separator
            bool multiplePeriods = input.IndexOf('.') != input.LastIndexOf('.');
            bool multipleCommas = input.IndexOf(',') != input.LastIndexOf(',');

            if (multiplePeriods && multipleCommas)
            {
                throw new Exception("multiplePeriods && multipleCommas");
            }

            if (multiplePeriods && !multipleCommas)
            {
                return System.Convert.ToDouble(input, new CultureInfo("da-DK"));
            }

            if (!multiplePeriods && multipleCommas)
            {
                return System.Convert.ToDouble(input, new CultureInfo("en-US"));
            }

            //Hvis der er max én af hver slags, så er den bagerste decimal-separator
            if (input.LastIndexOf('.') > input.LastIndexOf(','))
            {
                return System.Convert.ToDouble(input, new CultureInfo("en-US"));
            }

            if (input.LastIndexOf(',') > input.LastIndexOf('.'))
            {
                return System.Convert.ToDouble(input, new CultureInfo("da-DK"));
            }

            //Og, endelig, hvis der ikke er nogen, så er det simpelt nok:
            return System.Convert.ToDouble(input);
        }
    }
}
