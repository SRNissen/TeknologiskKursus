/*Du skal i Program-klassen i en ny konsol-applikationskabe
 * skabe en statisk SmartToUpper-metode,
 * som modtager en streng som argument,
 * og returnerer strengen med små bogstaver
 * bortset fra det første bogstav som skal være stort.
 * Altså "mikkel" bliver til "Mikkel"
 * og "MAtHiAs" bliver til "Mathias".*/

using System;

namespace ErrorHandling_Exceptions_RollingYourOwn
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine(SmartToUpper("mikkel"));
                Console.WriteLine(SmartToUpper("mAtHiAs"));
                Console.WriteLine(SmartToUpper("a"));
            }
            catch (Exception)
            {

                throw;
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static string SmartToUpper(string input)
        {
            if (input == null)
            {
                throw new ApplicationException("Object Reference is not set to an instance of Object");
            }

            if (input.Length == 0)
            {
                throw new ApplicationException("TextMustBeLongerThanZero");
            }

            string FirstLetter = input.Substring(0, 1).ToUpper();
            string otherLetters = input.Substring(1).ToLower();
            string output = FirstLetter + otherLetters;
            return output;
        }
    }
}
