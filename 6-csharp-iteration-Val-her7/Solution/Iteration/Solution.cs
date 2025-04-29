using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    public class Solution
    {
        public static int SumOfNumbers()
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The factorial of a negative number doesn't exists!");
            }
            else
            {
                int factorial = 1;
                while (number > 0)
                {
                    factorial *= number;
                    number--;
                }
                return factorial;
            }
        }

        public static void MultiplicationTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }

        public static void ValidateUserInput()
        {
            int number = 0;
            do
            {
                Console.WriteLine("Enter a number between 1 and 10: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    Console.WriteLine($"You enterred the number {number}");
                }
                else
                {
                    Console.WriteLine("Enter a valid number.");
                }
            } while (!(number >= 1 && number <= 10));
            Console.WriteLine("Great, you entered a number between 1 and 10!");
        }

        public static void SmallestNumber()
        {
            int min;
            int number;
            Console.WriteLine("Enter a number (0 to exit)");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Please enter a valid number: ");
            }
            min = number;
            while (number != 0)
            {
                Console.WriteLine("Enter a number (0 to exit)");
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Please enter a valid number: ");
                }
                min = (number < min && number != 0) ? number : min;
            }
            Console.WriteLine($"The smallest number enterred is {min}");
        }
    }
}