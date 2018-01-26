using System;
namespace eek_2018_oop_3
{
    class Auto : Vehicle
    {
        protected int seats;
        protected string drive; // 4WD, rear wheel drive, etc

        public Auto(int releaseYear = 0, string registryNumber = "--", double weight = 0, double price = 0,
                   int seats = 0, string drive = "---")
            : base(releaseYear, registryNumber, weight, price)
        {
            this.seats = seats;
            this.drive = drive;
        }

        public Auto(Auto ob) : base(ob)
        { this.seats = ob.seats;  this.drive = ob.drive; }

        public override void DrivingEnvironment() { Console.WriteLine("The car drives on land"); }

        public override void PrintMe()
        {
            base.PrintMe();
            Console.Write(" {0,3} {1,8}  ", seats, drive);
        }

        public virtual double CalculateFuelConsumption() { return 0; }

        public override double CalculateCurrentPrice()
        {
            int age = CalculateAge();
            double newPrice = stickerPrice;

            for (int i = 1; i < age; i++)
            {
                newPrice *= 0.84; // How much auto price will deprecate per year
            }
            return newPrice;
        }
    }
}
