using System;
using System.Collections.Generic;

namespace Ferry
{
    class Program {
        static void Main(string[] args)
        {
            FerryKata ferryKata = new FerryKata(3, 5);
            Console.WriteLine(ferryKata.Board(new Car("red", 3), 4));
            Console.WriteLine($"Number of cars in this ferry: {ferryKata.GetCarCount()}");
            Console.WriteLine($"Number of people in this ferry: {ferryKata.GetPeopleCount()}");
        }
    }
}