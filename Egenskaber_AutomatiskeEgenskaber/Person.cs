namespace Egenskaber_AutomatiskeEgenskaber
{
    internal class Person
    {
        public string Fornavn { get; set; }
        private string efternavn;

        public string Efternavn
        {
            get { return efternavn; }
            set { efternavn = (value.Length < 3) ? "" : value; }
        }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }
}
