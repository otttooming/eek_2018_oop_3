using System;
namespace eek_2018_oop_3
{
    class Plane : Vehicle
    {
        protected int maxHeight;
        protected int numberOfEngines;

        public Plane(int releaseYear = 0, string registryNumber = "--", double weight = 0, double price = 0,
                     int maxHeight = 0, int numberOfEngines = 0)
            : base(releaseYear, registryNumber, weight, price)
        {
            this.maxHeight = maxHeight;
            this.numberOfEngines = numberOfEngines;
        }

        public override void DrivingEnvironment()
        {
            Console.WriteLine("Plane flies in the skies");
        }

        public override double CalculateCurrentPrice()
        {
            int age = CalculateAge();
            double newPrice = stickerPrice;

            for (int i = 1; i <= age; i++)
            {
                if (i <= 15)
                {
                    newPrice *= 0.9;

                }
                else
                {
                    newPrice *= 0.84;
                }
            }

            return newPrice;
        }

        public override void PrintMe()
        {
            base.PrintMe();
            Console.Write(" {0,4:f1} {1,5:f1}", maxHeight, numberOfEngines);
        }
    }
}
