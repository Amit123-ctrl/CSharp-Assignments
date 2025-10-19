using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Q1. Handling Division by Zero
            try
            {
                Console.Write("Enter the first number: ");
                 int num1 = int.Parse(Console.ReadLine());
               // int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine("Result = " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }*/
            /* Q2. Multiple Catch Blocks 
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            try
            {
                int number = Convert.ToInt32(input);
                Console.WriteLine("You entered: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input is not in a correct format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Input number is too large or too small for an Int32.");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred.");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }*/

            /* Q3. Custom Exception for Negative Salary 
            try
            {
                Console.Write("Enter salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());

                if (salary < 0)
                {
                    throw new NegativeSalaryException("Salary cannot be negative.");
                }

                Console.WriteLine("Salary entered: " + salary);
            }
            catch (NegativeSalaryException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid salary format.");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }*/

            /*
            decimal balance = 1000m;  // Example initial balance

            Console.Write("Enter amount to withdraw: ");
            decimal withdrawal;

            try
            {
                withdrawal = decimal.Parse(Console.ReadLine());

                if (withdrawal > balance)
                {
                    throw new InsufficientBalanceException("Withdrawal amount exceeds available balance.");
                }

                balance -= withdrawal;
                Console.WriteLine("Withdrawal successful. Remaining balance: " + balance);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid amount format.");
            }
            finally
            {
                Console.WriteLine("Transaction completed.");
            }*/

            // Q5. Student Marks Validation 
            try
            {
                Student student = new Student();

                Console.Write("Enter marks (0-100): ");
                int inputMarks = int.Parse(Console.ReadLine());

                student.Marks = inputMarks;  // Validate and set marks

                Console.WriteLine("Marks entered: " + student.Marks);
            }
            catch (InvalidMarksException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format.");
            }
            finally
            {
                Console.WriteLine("Validation completed.");
            }
        }
    }
}
public class NegativeSalaryException : Exception
{
    public NegativeSalaryException(string message) : base(message)
    {
    }
}

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

public class InvalidMarksException : Exception
{
    public InvalidMarksException(string message) : base(message)
    {
    }
}

public class Student
{
    private int marks;

    public int Marks
    {
        get { return marks; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new InvalidMarksException("Marks must be between 0 and 100.");
            }
            marks = value;
        }
    }
}