namespace Egenskaber_KompletteEgenskaber
{
    class Vare
    {
        private string navn;
        public string Navn
        {
            get { System.Console.WriteLine(navn); return navn;  }
            set { navn = value; System.Console.WriteLine(navn); }
        }

        private double pris;
        public double Pris
        {
            get { System.Console.WriteLine( pris); return pris; }
            set { pris = value; System.Console.WriteLine(value); }
        }

        public double PrisMedMoms()
        {
            return pris * 1.25;
        }

        public Vare() { }
        public Vare(string Navn, double Pris)
        {
            navn = Navn; pris = Pris;
        }

    }

}
