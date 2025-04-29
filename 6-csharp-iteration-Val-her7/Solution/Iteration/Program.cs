namespace Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.SumOfNumbers());
            Console.WriteLine("Enter a number: ");

            string? input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                try
                {
                    Console.WriteLine(Solution.Factorial(number));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
            }

            Solution.MultiplicationTable();
            Solution.ValidateUserInput();
            Solution.SmallestNumber();

        }
    }
}
