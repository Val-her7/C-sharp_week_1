namespace StringChar
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            //1
            try
            {
                Console.WriteLine(Solution.ReversedString(input));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e.Message}");
            }

            //2
            try
            {
                Console.WriteLine(Solution.CountVowels(input));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e.Message}");
            }

            //3
            try
            {
                Console.WriteLine(Solution.isPalindrome(input));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e.Message}");
            }

            //4
            try
            {
                Console.WriteLine(Solution.FirstNonRepeatingCharacter(input));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e.Message}");
            }
        }
    }
}
