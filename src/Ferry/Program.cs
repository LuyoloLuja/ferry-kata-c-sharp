using System;
using System.Collections.Generic;

namespace Ferry
{
    class Program {
        static void Main(string[] args)
        {
            FerryKata ferryKata = new FerryKata(3, 5);
            Car car = new Car("red", 3);
            Car car2 = new Car("red", 3);
            Car car3 = new Car("green", 3);
            Console.WriteLine(ferryKata.Board(car, 4));
            Console.WriteLine(ferryKata.Board(car2, 4));
            Console.WriteLine(ferryKata.Board(car2, 4));
            Console.WriteLine(ferryKata.Board(car2, 4));
            Console.WriteLine(ferryKata.Board(car2, 4));
            // Console.WriteLine($"Number of cars in this ferry: {ferryKata.GetCarCount()}");
            // Console.WriteLine($"Number of people in this ferry: {ferryKata.GetPeopleCount()}");
            Console.WriteLine(ferryKata.GiveDiscount(car2));
        }
    }
}