using System;
namespace eek_2018_oop_3
{
    class Ship : Vehicle
    {
        protected int displacement;
        protected string type;

        public Ship(int releaseYear = 0, string registryNumber = "--", double weight = 0, double price = 0,
                   int displacement = 0, string type = "---")
            : base(releaseYear, registryNumber, weight, price)
        {
            this.displacement = displacement;
            this.type = type;
        }

        public Ship(Ship ob)
            : base(ob)
        {
            this.displacement = ob.displacement;
            this.type = ob.type;
        }

        public override void DrivingEnvironment()
        {
            Console.WriteLine("Ship move in water");
        }

        public override double CalculateCurrentPrice()
        {
            int age = CalculateAge();
            double newPrice = stickerPrice;

            for (int i = 1; i <= age; i++)
            {
                if (i <= 15)
                {
                    newPrice *= 0.91;

                } 
                else
                {
                    newPrice *= 0.88;
                }
            }

            return newPrice;
        }

        public override void PrintMe()
        {
            base.PrintMe();

            Console.Write(" {0,3} {1,-10}  ", displacement, type);
        }
    }
}
