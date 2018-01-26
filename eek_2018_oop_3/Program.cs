using System;

namespace eek_2018_oop_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Auto Honda = new Auto(2004, "354FFF", 1.4, 10000, 4, "Front wheel");
            Auto Audi = new Auto(2012, "333ABD", 2.4, 34000, 2, "4WD");
            Auto BMW = new Auto(1993, "777ABC", 1.9, 20400, 3, "Rear wheel");

            Honda.PrintMe();
            Console.WriteLine();
            double currentPrice = Honda.CalculateCurrentPrice();
            Console.WriteLine("Current price will be: {0,10:f2}", currentPrice);


            /*
                Ship
            */

            Ship Nimitz = new Ship(2015, "123FGH", 10000, 100000, 498, "CVN");
            Ship Perry = new Ship(1987, "428FGH", 1900, 72000, 240, "DDG");
            Nimitz.PrintMe();
            Console.WriteLine();
            Perry.PrintMe();

            Console.Read();
        }
    }
}
