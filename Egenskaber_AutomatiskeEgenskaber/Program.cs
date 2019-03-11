using System;

namespace Egenskaber_AutomatiskeEgenskaber
{
    class Program
    {
        static void Main(string[] args)
        {

            var person1 = new Person();
            person1.Fornavn = "Henrik";
            person1.Efternavn = "Bo";
            Console.WriteLine(person1.FuldtNavn());

            var person2 = new Person();
            person2.Fornavn = "Henrik";
            person2.Efternavn = "Bo-Jakobsen";
            Console.WriteLine(person2.FuldtNavn());


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
