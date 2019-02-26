/*
 I en ny konsol applikation skal du

Oprette to strenge – fornavn (Mikkel) og efternavn (Cronberg)
Oprette en samlet streng samletNavn og sørge for at den får værdien ”Mikkel Cronberg”
Oprette en samlet streng navnStort som ud fra samletNavn får værdien ”MIKKEL CRONBERG”
Oprette en streng navnLille som ud fra samletNavn får værdien ”mikkel cronberg”
Oprette en streng som ud fra samletNavn får værdien ”Cron” (brug eksempelvis SubString-metoden)
Prøv eventuelt at

Lege escape karakterer (tab = \t, newline = \r\n) (skriv ud til console)
Gemme en streng til en fil (System.IO.File.WriteAllText())
Danne en streng som en interpoleret streng ($"")  
 */

using System;

namespace BrugAfVariabler_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = $"{fornavn} {efternavn}";
            string samletStort = samletNavn.ToUpper();
            string samletLille = samletNavn.ToLower();
            string kortNavn = samletNavn.Substring(7, 4);
            string output = $"Fornavn: {fornavn}\r" +
                $"Efternavn: {efternavn}\r" +
                $"Samlet navn: {samletNavn}\r" +
                $"Stort navn: {samletStort}\r" +
                $"Lille navn: {samletLille}\r" +
                $"Kort navn:: {kortNavn}\r";
            Console.WriteLine(output);
            System.IO.File.WriteAllText("c:\\temp\\BrugAfVariabler_Text.txt", output);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
