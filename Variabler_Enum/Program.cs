using System;

namespace Variabler_Enum
{
    class Program
    {
        static void Main(string[] args)
        {

            Sæt sæt = new Sæt();

            Console.WriteLine(sæt.AlleKort());



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }


    public class Sæt
    {
        System.Collections.Generic.List<Kort> kort = new System.Collections.Generic.List<Kort>();

        public Sæt()
        {
            foreach (var værdi in Enum.GetValues(typeof(Kort.Værdi)))
            {
                foreach (var kulør in Enum.GetValues(typeof(Kort.Kulør)))
                {
                    switch (kulør)
                    {
                        case Kort.Kulør.Hjerter:
                            kort.Add(new Kort((Kort.Kulør)kulør, Kort.Farve.Rød, (Kort.Værdi)værdi));
                            break;

                        case Kort.Kulør.Ruder:
                            kort.Add(new Kort((Kort.Kulør)kulør, Kort.Farve.Rød, (Kort.Værdi)værdi));
                            break;

                        case Kort.Kulør.Spar:
                            kort.Add(new Kort((Kort.Kulør)kulør, Kort.Farve.Sort, (Kort.Værdi)værdi));
                            break;

                        case Kort.Kulør.Klør:
                            kort.Add(new Kort((Kort.Kulør)kulør, Kort.Farve.Sort, (Kort.Værdi)værdi));
                            break;
                    }
                }
            }

        } //Constructor

        public class Kort
        {
            public Kulør kulør_;
            public Farve farve_;
            public Værdi værdi_;
            public Kort(Kulør kulør, Farve farve, Værdi værdi)
            {
                kulør_ = kulør;
                farve_ = farve;
                værdi_ = værdi;
            }

            public enum Kulør
            {
                Hjerter, Ruder, Spar, Klør
            }

            public enum Farve
            {
                Rød, Sort
            }

            public enum Værdi
            {
                Es = 1,
                To = 2,
                Tre = 3,
                Fire = 4,
                Fem = 5,
                Seks = 6,
                Syv = 7,
                Otte = 8,
                Ni = 9,
                Ti = 10,
                Knægt = 11,
                Dame = 12,
                Konge = 13,
                Joker = 14
            }
        }

        public string AlleKort()
        {
            string returnString = "";

            foreach (var item in kort)
            {
                returnString += $"{item.kulør_} {item.værdi_} er {item.farve_}\n";
            }

            return returnString;
        }

    }
}