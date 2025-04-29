namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1
            Solution.Random10();

            int[] numbers = { 41, 99, 17, 45, 11 };
            //2
            Console.WriteLine(Solution.Sum(numbers));
            Console.WriteLine(Solution.Average(numbers));

            //3
            Solution.MaxAndMin(numbers, out int max, out int min);

            //4
            int numberInput;
            Console.WriteLine("How many numbers are you going to enter? ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numberInput) && numberInput > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid positive number please.");
                }
            }
            int[] numbersToSort = new int[numberInput];
            for (int i = 0; i < numberInput; i++)
            {
                int number;
                Console.WriteLine($"Enter number {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Please enter a valid number!");
                }
                numbersToSort[i] = number;
            }
            string sortedNumbers = string.Join(", ", Solution.SortAndArray(numbersToSort));
            Console.WriteLine(sortedNumbers);

            //5
            int[] x = { 1, 2, 4, 2, 1 };
            int[] y = { 1, 2, 4, 2, 2 };
            string[] z = { "a", "b", "c", "b", "a" };
            string[] w = { "a", "d", "c", "b", "a" };
            Console.WriteLine(Solution.Palindrome(x));
            Console.WriteLine(Solution.Palindrome(y));
            Console.WriteLine(Solution.Palindrome(z));
            Console.WriteLine(Solution.Palindrome(w));
        }
    }
}