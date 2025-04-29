namespace Selection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, what is your age?");
                Console.WriteLine(Solution.CanEnterInTheCasino());
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e}");
            }

            try
            {
                Console.WriteLine("Enter a number: ");
                string? input = Console.ReadLine();
                if(int.TryParse(input, out int number)){
                    Console.WriteLine(Solution.SignOfNumber(number));
                }
                else {
                    throw new FormatException("Invalid Number");
                }
                
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e}");
            }

            try{
                Console.WriteLine("Enter the initial price: ");
                string? price = Console.ReadLine();
                if(double.TryParse(price, out double number)){
                    Console.WriteLine("Choose the discount (1 = 10% discount for students, 2 = 5% discount for members, 3 = 20% discount for sale products)");
                    string ? discount = Console.ReadLine();
                    if(int.TryParse(discount, out int disc)){
                        Console.WriteLine($"The final price is equal to {Solution.DiscountPriceCalculator(disc, number)}");
                    }
                    else {
                       throw new FormatException("Invalid discount"); 
                    }
                }
                else {
                    throw new FormatException("Invalid price");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e}");
            }

            Console.WriteLine(Solution.TriangleClassification(2,0,9));
        }
    }
}
