namespace Variabler_Struct
{
    partial class Program
    {
        public struct Vare
        {
            public int Id;
            public string Navn;
            public string Beskrivelse;
            public double Pris;

            public Vare(int id, string navn, string beskrivelse, double pris)
            {
                Id = id;
                Navn = navn;
                Beskrivelse = beskrivelse;
                Pris = pris;
            }
        }
    }
}
