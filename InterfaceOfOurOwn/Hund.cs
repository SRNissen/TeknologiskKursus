namespace InterfaceOfOurOwn
{
    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }

        public void Gem()
        {
            System.Console.WriteLine("Gemmer Hund");
        }
    }
}
