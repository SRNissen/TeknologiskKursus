using System;

namespace Klasser_SimpelKlasse
{
    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;
        
        public Person(string fornavn, string efternavn, int fødselsår)
        {
            Fornavn = fornavn; Efternavn = efternavn; Fødselsår = fødselsår;
        }

        public Person() : this("","",0)
        {

        }


        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }

        public int Alder()
        {
            return System.DateTime.Now.Year - Fødselsår;
        }
    }
}
