namespace Arv_Terning
{
    internal class Terning
    {
        private static System.Random Rnd = new System.Random();

        protected int Value;

        public virtual void Set(int value = 0)
        {
            if (0 < value && value < 7)
            {
                Value = value;
            }
            else
            {
                Shake();
            }
        }

        public void Shake()
        {
            Value = (Rnd.Next() % 6) + 1;
        }

        public virtual void Write()
        {
            System.Console.WriteLine($"[{Value}]");
        }

        public Terning(int initial = 0)
        {
            Set(initial);
        }


    }

    internal class LudoTerning : Terning
    {
        public override void Write()
        {
            if (Value == 3)
            {
                System.Console.WriteLine($"[G]");
                return;
            }
            if (Value == 5)
            {
                System.Console.WriteLine($"[S]");
                return;
            }
            System.Console.WriteLine($"[{Value}]");
        }

        public LudoTerning(int initial = 0) : base(initial) { }

        public LudoTerning(char initial)
        {
            if (initial == 'S')
            {
                Set(5);
            }
            else
            {
                Set(3);
            }
        }
}

    


}
