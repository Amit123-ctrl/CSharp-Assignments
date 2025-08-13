using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_b_
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Price cannot be negative. Setting to 0.");
                    price = 0;
                }
                else
                {
                    price = value;
                }
            }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Quantity cannot be negative. Setting to 0.");
                    quantity = 0;
                }
                else
                {
                    quantity = value;
                }
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine("Product Details:");
            Console.WriteLine($"ID: {ProductID}");
            Console.WriteLine($"Name: {ProductName}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine();
        }
    }
}
