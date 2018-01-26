using System;
namespace eek_2018_oop_3
{
    abstract class Vehicle : IUtility
    {
        protected int releaseYear; // Vehicle release year
        public string registryNumber { get; set; } // Registry number
        protected double weight;

        public Vehicle(int releaseYear = 0, string registryNumber = "--", double weight = 0)
        {
            this.releaseYear = releaseYear;
            this.registryNumber = registryNumber;
            this.weight = weight;
        }

        public Vehicle(Vehicle v)
        {
            this.releaseYear = v.releaseYear;
            this.registryNumber = v.registryNumber;
            this.weight = v.weight;
        }

        public virtual void PrintMe()
        {
            Console.Write("{0,4} {1,8} {2,9:f1}", releaseYear, registryNumber, weight);
        }

        public int CalculateAge()
        {
            DateTime today = DateTime.Now;
            int age = today.Year - releaseYear;

            return age;
        }

        public abstract void DrivingEnvironment();
    }
}
