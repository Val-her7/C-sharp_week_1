namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine(Solution.Sum(2,5));

            //2
            Console.WriteLine(Solution.Whos("Valentin", "Herman", 24));

            //3
            int a = 3;
            int b = 4;

            Solution.SumAndProduct(a, b, out int sum, out int product);
            Console.WriteLine(sum);
            Console.WriteLine(product);

            //4
            int c = 10;
            int d = 3;
            (int quotient, int remainder) = Solution.QuotientAndRemainder(c, d);
            Console.WriteLine(quotient);
            Console.WriteLine(remainder);

            //5
            Console.WriteLine(Solution.MethodWithDefaultValue(5));
        }
    }
}
