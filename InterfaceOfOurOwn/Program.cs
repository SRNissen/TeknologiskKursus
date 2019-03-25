using System;
using System.Collections.Generic;

namespace InterfaceOfOurOwn
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDbFunktioner> tingDerSkalGemmes = new List<IDbFunktioner>();

            tingDerSkalGemmes.Add(new Ubåd());
            tingDerSkalGemmes.Add(new Hund());
            tingDerSkalGemmes.Add(new Ubåd());
            tingDerSkalGemmes.Add(new Ubåd());
            tingDerSkalGemmes.Add(new Hund());
            tingDerSkalGemmes.Add(new Hund());
            tingDerSkalGemmes.Add(new Hund());
            tingDerSkalGemmes.Add(new Ubåd());
            tingDerSkalGemmes.Add(new Hund());
            tingDerSkalGemmes.Add(new Hund());
            tingDerSkalGemmes.Add(new Ubåd());
            tingDerSkalGemmes.Add(new Ubåd());
            tingDerSkalGemmes.Add(new Ubåd());
            tingDerSkalGemmes.Add(new Hund());
            tingDerSkalGemmes.Add(new Ubåd());
            tingDerSkalGemmes.Add(new Hund());

            foreach (var item in tingDerSkalGemmes)
            {
                item.Gem();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
