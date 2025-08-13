using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Lab2_b_
{
    internal class Student
    {
        public string Name { get; set; }
        public int RollNumber { get; set; }
        public double Marks { get; set; }
        public Student()
        {
            Name = "Unknown";
            RollNumber = 0;
            Marks = 0.0;
        }

        public Student(string name, int rollNumber)
        {
            Name = name;
            RollNumber = rollNumber;
            Marks = 0.0;
        }
        public Student(string name, int rollNumber, double marks)
        {
            Name = name;
            RollNumber = rollNumber;
            Marks = marks;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine($"Marks: {Marks}");
            Console.WriteLine();
        }
    }
}
