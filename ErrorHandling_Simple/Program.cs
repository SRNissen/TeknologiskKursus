/*
 * Du skal skabe en tom konsol app med følgende kode:

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    private static void Run()
    {
        Console.WriteLine("Indtast 1. tal");
        int tal1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Indtast 2. tal");
        int tal2 = Convert.ToInt32(Console.ReadLine());
        int res = tal1 + tal2;
        Console.WriteLine("resultatet er " + res);
    }
}
Se om koden virker ved at indtaste to tal.
Prøv så at indtaste noget der ikke kan konverteres til et tal.
Den skulle gerne fejle.
Sørg for at tilføje den korrekte fejlhåndtering,
og skriv ”Der er sket en fejl
– [den konkret exception message]” ved en eventuel fejl.

Overvej hvordan koden kan ændres således, at brugeren blot bliver bedt om at prøve igen - dog max 3 gange. Se forslag til løsning i metoden PrøvIgen.

(Se projektet ErrorHandling_Simple_Retry)
 
 */
using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Run();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void Run()
    {
        Console.WriteLine("Indtast 1. tal");
        int tal1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Indtast 2. tal");
        int tal2 = Convert.ToInt32(Console.ReadLine());
        int res = tal1 + tal2;
        Console.WriteLine("resultatet er " + res);
    }
}