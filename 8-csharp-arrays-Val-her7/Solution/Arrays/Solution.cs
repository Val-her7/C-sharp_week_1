using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Solution
    {
        public static void Random10()
        {
            Random random = new Random();
            int[] array10Randoms = new int[10];
            for (int i = 0; i < array10Randoms.Length; i++)
            {
                array10Randoms[i] = random.Next(1, 11);
                Console.WriteLine(array10Randoms[i]);
            }
        }

        public static int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public static double Average(int[] numbers)
        {
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            double average = sum / numbers.Length;
            return average;
        }

        public static void MaxAndMin(int[] number, out int max, out int min)
        {
            min = number.Min();
            max = number.Max();
            Console.WriteLine($"Max: {max}, Min: {min}");
        }

        public static int[] SortAndArray(int[] numbers)
        {
            int[] sortedArray = (int[])numbers.Clone();
            Array.Sort(sortedArray);
            return sortedArray;
        }

        public static string Palindrome<T>(T[] data)
        {
            bool isPalindrome = true;
            for (int i = 0; i < data.Length / 2; i++)
            {
                if (!data[i].Equals(data[data.Length - 1 - i]))
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome ? "The array is a palindrome" : "The array is not a palindrome";
        }
    }
}