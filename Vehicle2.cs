using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Lab2_b_
{
    // Base class Vehicle
    internal class Vehicle2
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle2(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }

    // Derived class Bus
    internal class Bus : Vehicle2
    {
        public int Capacity { get; set; }

        public Bus(string make, string model, int year, int capacity)
            : base(make, model, year)
        {
            Capacity = capacity;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Bus Details:");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Capacity: {Capacity}");
        }
    }

    // Derived class Truck
    internal class Truck : Vehicle2
    {
        public string Color { get; set; }

        public Truck(string make, string model, int year, string color)
            : base(make, model, year)
        {
            Color = color;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Truck Details:");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Color: {Color}");
        }
    }
}
