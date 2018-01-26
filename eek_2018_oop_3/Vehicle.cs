using System;
namespace eek_2018_oop_3
{
    abstract class Vehicle : IUtility
    {
        protected int releaseYear; // Vehicle release year
        public string registryNumber { get; set; } // Registry number
        protected double weight;
        protected double stickerPrice;

        public Vehicle(int releaseYear = 0, string registryNumber = "--", double weight = 0, double stickerPrice = 0)
        {
            this.releaseYear = releaseYear;
            this.registryNumber = registryNumber;
            this.weight = weight;
            this.stickerPrice = stickerPrice;
        }

        public Vehicle(Vehicle v)
        {
            this.releaseYear = v.releaseYear;
            this.registryNumber = v.registryNumber;
            this.weight = v.weight;
            this.stickerPrice = v.stickerPrice;
        }

        public virtual void PrintMe()
        {
            Console.Write("{0,4} {1,8} {2,9:f1} {3,9:f2}", releaseYear, registryNumber, weight, stickerPrice);
        }

        public int CalculateAge()
        {
            DateTime today = DateTime.Now;
            int age = today.Year - releaseYear;

            return age;
        }

        public abstract void DrivingEnvironment();

        /*
            Calculate vehicle price deprecation
        */
        public abstract double CalculateCurrentPrice();
    }
}
