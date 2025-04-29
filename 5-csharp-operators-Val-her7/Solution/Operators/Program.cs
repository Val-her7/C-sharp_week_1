namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(Solution.IsAdult(age));

            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Solution.EvenOrOdd(number));

            Console.WriteLine("Enter first number: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine($"The addition of {numberOne} and {numberTwo} equals to {Solution.Add(numberOne, numberTwo)}");

            Console.WriteLine("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"The maximum between {firstNumber} and {secondNumber} is {Solution.Max(firstNumber, secondNumber)}");
        }
    }
}
