namespace Klasser_Terning
{
    internal class Terning
    {
        public int værdi;
        private bool snyd;
        private static System.Random rnd = new System.Random();
        public void Skriv()
        { System.Console.WriteLine(værdi); }
        public void Ryst()
        { værdi = snyd ? 6 : rnd.Next(1, 7); }

        public Terning() : this(false) { }
        public Terning(bool Snyd)
        {
            værdi = 1; snyd = Snyd;
        }

    }
}
