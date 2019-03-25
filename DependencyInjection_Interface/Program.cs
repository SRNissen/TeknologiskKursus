using System;

namespace DependencyInjection_Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            Terning t = new Terning(new TilfældighedsGeneratorMock(3));

            t.Ryst();
            t.Ryst();
            t.Ryst();
            t.Ryst();
            t.Ryst();
            t.Ryst();
            t.Ryst();
            t.Ryst();

            t = new Terning(new TilfældighedsGeneratorFramework());
            t.Ryst();
            t.Ryst();
            t.Ryst();
            t.Ryst();
            t.Ryst();
            t.Ryst();
            t.Ryst();
            t.Ryst();


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    interface ITilfældighedsGenerator
    {
        int FindTalTilTerning();
    }

    internal class TilfældighedsGeneratorFramework : ITilfældighedsGenerator
    {
        private static System.Random Rnd = new System.Random();

        int ITilfældighedsGenerator.FindTalTilTerning()
        {
            return Rnd.Next(1, 7);
        }
    }

    internal class TilfældighedsGeneratorMock : ITilfældighedsGenerator
    {
        private int Value;

        int ITilfældighedsGenerator.FindTalTilTerning()
        {
            return this.Value;
        }

        public TilfældighedsGeneratorMock(int a)
        {
            Value = a;
        }

    }

    internal class Terning
    {
        public int Værdi { get; set; }
        private ITilfældighedsGenerator Rnd;
        public void Ryst()
        {
            Console.WriteLine(Rnd.FindTalTilTerning());
        }

        public Terning(ITilfældighedsGenerator input)
        {
            Rnd = input;
        }
    }
}
