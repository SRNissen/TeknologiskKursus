namespace Arv_Polymorfi
{
    internal abstract class Dyr
    {
        static System.Random Rnd = new System.Random();
        public string Navn { get; set; }
        virtual public void SigNoget()
        {
            System.Console.WriteLine($"Jeg er et dyr og hedder {Navn}");
        }

        public static Dyr TilfældigtDyr()
        {
            if (Rnd.Next() % 2>0)
            {
                return new Kat() { Navn = "Kisser" };
            }
            else
            {
                return new Hund() { Navn = "Buller" };
            }
        }

    }

    internal class Hund : Dyr
    {
        override public void SigNoget()
        {
            System.Console.WriteLine($"Jeg er en hund og hedder {Navn}");
        }
    }

    internal class Kat : Dyr
    {
        override public void SigNoget()
        {
            System.Console.WriteLine($"Jeg er en kat og hedder {Navn}");
        }
    }

}
