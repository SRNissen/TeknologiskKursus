namespace Egenskaber_GetSomMetoder
{
    internal class Trekant
    {
        private int grundlinje;

        public int Grundlinje
        {
            get { return grundlinje; }
        }

        private int højde;

        public int Højde
        {
            get { return højde; }
        }

        public double Areal
        {
            get { return 0.5*(højde*grundlinje); }
        }

        public Trekant(int Højde, int Grundlinje)
        {
            højde = Højde;grundlinje = Grundlinje;
        }
    }
}
