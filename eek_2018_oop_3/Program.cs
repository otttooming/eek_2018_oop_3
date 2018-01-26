using System;
using System.Collections;
using System.Collections.Generic;

namespace eek_2018_oop_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Auto Honda = new Auto(2004, "354FFF", 1.4, 10000, 4, "Front");
            Auto Audi = new Auto(2012, "333ABD", 2.4, 34000, 2, "4WD");
            Auto BMW = new Auto(1993, "777ABC", 1.9, 20400, 3, "Rear");

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

            /*
                Plane
            */

            Plane Bell = new Plane(1987, "999REA", 1900, 12000, 100, 4);
            Plane Apollo = new Plane(2014, "428FGH", 1900, 10000, 100, 2);
            Plane TriJet = new Plane(2011, "4548FGH", 4300, 88000, 100, 3);

            /*
                List
            */
            Console.WriteLine();

            List<Vehicle> DHLVehicles = new List<Vehicle>();
            DHLVehicles.Add(Honda);
            DHLVehicles.Add(Nimitz);
            DHLVehicles.Add(Bell);
            DHLVehicles.Insert(2, Audi);
            DHLVehicles.Add(Perry);
            DHLVehicles.Add(Apollo);
            DHLVehicles.Add(BMW);
            DHLVehicles.Add(TriJet);

            foreach(Vehicle x in DHLVehicles)
            {
                x.PrintMe();
                x.DrivingEnvironment();
                Console.Write("  {0,0:f2}", x.CalculateCurrentPrice());

                if (x is Auto)
                {
                    Console.WriteLine(" EUR");
                }
                else
                {
                    Console.WriteLine(" M EUR");
                }
            }

            Console.WriteLine();
            Console.Read();
        }
    }
}
