/*
Du skal skabe en applikation som

Først checke om filen c:\temp\tal.txt eksisterer (System.IO.File.Exists).
Hvis den ikke findes skal der smides en ApplikationException med teksten "Filen c:\temp\tal.txt findes ikke!"
I en try/catch-struktur skal du nu
    Åbne filen og hent indhold til en streng (System.IO.File.ReadAllText).
        Hvis det går galt skal fejlen blot smides videre.
    Konverter indhold til et heltal (int32) ved hjælp af Convert.ToInt32.
        Hvis det går galt smider ToInt32 en FormatException.
        I så fald skal du smide en ApplikationException med teksten "Indhold kan ikke konverteres til et heltal".
    Læg nu 1 til tallet og gem det igen (System.IO.File.WriteAllText).
        Hvis det går galt skal fejlen blot smides videre.
 */


using System;

namespace ErrorHandling_Exceptions_RollingYourOwn_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if(!System.IO.File.Exists(@"c:\temp\tal.txt"))
                {
                    throw new ApplicationException(@"Filen c:\temp\tal.txt findes ikke!");
                }

            }
            catch (Exception)
            {

            }








            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
