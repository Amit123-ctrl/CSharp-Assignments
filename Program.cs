using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_b_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Question 1
            Program a =new Program();
            a.set();
            Program b=new Program();
            b.set();
            a.get();
            b.get();

            //  Question 2
            Bus bus = new Bus("Mercedes", "Sprinter", 2022, 30);
            bus.DisplayDetails();
            Truck truck = new Truck("Volvo", "FH", 2021, "Blue");
             truck.DisplayDetails();
         
            //Question 3
            Calculator calc = new Calculator();

            Console.WriteLine("Add(int, int): " + calc.Add(2, 3));
            Console.WriteLine("Add(int, int, int): " + calc.Add(1, 2, 3));
            Console.WriteLine("Add(float, float): " + calc.Add(2.5f, 3.5f));
            Console.WriteLine("Add(double, double): " + calc.Add(1.1, 2.2));
            Console.WriteLine("Add(double, double, double): " + calc.Add(1.1, 2.2, 3.3));
         
            // Question 4   
            FullTimeEmployee fte = new FullTimeEmployee("Alice", 5000);
            PartTimeEmployee pte = new PartTimeEmployee("Bob", 20, 80);
            Console.WriteLine($"{fte.Name} (Full-Time) Salary: {fte.CalculateSalary()}");
            Console.WriteLine($"{pte.Name} (Part-Time) Salary: {pte.CalculateSalary()}");
        
            // Question 5 - Student record system demonstration
            Student s1 = new Student();
            Student s2 = new Student("John Doe", 101);
            Student s3 = new Student("Jane Smith", 102, 89.5);

            s1.Display();
            s2.Display();
            s3.Display();
         
            // Question 6 - Product   demonstration
            Product validProduct = new Product
            {
                ProductID = 1,
                ProductName = "Laptop",
                Price = 1200.50,
                Quantity = 10
            };
            validProduct.PrintDetails();

            Product invalidProduct = new Product
            {
                ProductID = 2,
                ProductName = "Mouse",
                Price = -50,      
                Quantity = -5    
            };
            invalidProduct.PrintDetails();
 
            // Question 7 - Library management system demonstration
            Library library = new Library();

            Book b1 = new Book(1, "C# Programming", "John Smith");
            Book b2 = new Book(2, "OOP Concepts", "Jane Doe");
            library.AddBook(b1);
            library.AddBook(b2);

            Member m1 = new Member(101, "Alice");
            Member m2 = new Member(102, "Bob");
            library.RegisterMember(m1);
            library.RegisterMember(m2);

            library.ShowAvailableBooks();

            library.LendBook(1, 101);
            library.ShowAvailableBooks();
            m1.DisplayInfo();
            m2.DisplayInfo();
        }
    }
}
