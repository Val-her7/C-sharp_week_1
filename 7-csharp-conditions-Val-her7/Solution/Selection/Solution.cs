using System;

namespace Selection
{
    public class Solution
    {
        public static string CanEnterInTheCasino()
        {
            string reponse;
            string? input = Console.ReadLine();
            int age = Solution.GetValidatedAge(input);
            if (age >= 18) reponse = "You can enter! Be welcome!";
            else reponse = "Sorry, you can't enter! Be patient!";
            return reponse;
        }

        public static int GetValidatedAge(string input)
        {
            if (int.TryParse(input, out int age))
            {
                if (age < 120)
                {
                    return age;
                }
                else
                {
                    throw new FormatException("Invalid Age");
                }
            }
            else
            {
                throw new FormatException("Invalid Age");
            }
        }

        public static string SignOfNumber(int number)
        {
            if (number > 0)
            {
                return "The number is positive.";
            }
            else if (number < 0)
            {
                return "The number is negative.";
            }
            else
            {
                return "The number is zero.";
            }
        }

        public static double DiscountPriceCalculator(int discount, double price)
        {
            switch (discount)
            {
                case 1:
                    price *= 0.9;
                    break;
                case 2:
                    price *= 0.95;
                    break;
                case 3:
                    price *= 0.8;
                    break;
                default:
                    throw new ArgumentException("Invalid choice. Please enter a number between 1 and 3.");
                    break;
            }
            return price;
        }

        public static string TriangleClassification(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return "The triangle is equilateral.";
            }
            else if(a == b || a == c || b == c){
                return "The triangle is isosceles.";
            }
            else
            {
                return "The triangle is scalene.";
            }
        }
    }
}
