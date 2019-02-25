/*Start en ny tom konsol applikation og sørg for følgende:

Erklær en variabel heltal som et 32 bit heltal og initialiser den til 10.
Brug ++ operatoren til at lægge 1 til variablen, -- operatoren til at trække 1 fra og += til at lægge 20 til.
Udskriv(Console.WriteLine) heltal.

Erklær en variabel kommatal som en double og initialiser den til 12,5.
Brug ++ operatoren til at lægge 1 til variablen, -- operatoren til at trække 1 fra og *= til at gange med 2
Udskriv kommatal.
*/


using System;

namespace BrugAfVariabler_Tal
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempInt = 10;
            tempInt++;
            tempInt--;
            tempInt += 20;
            Console.WriteLine(tempInt);

            double tempDouble = 12.5;
            tempDouble++;
            tempDouble--;
            tempDouble *= 2;
            Console.WriteLine(tempDouble);



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
