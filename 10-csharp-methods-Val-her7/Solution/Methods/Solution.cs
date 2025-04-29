using System;

namespace Methods
{
  public class Solution
  {
    public static int Sum(int a, int b)
    {
      return a + b;
    }

    public static string Whos(string firstName, string lastName, int age)
    {
      return $"Firstname : {firstName}\nLastname : {lastName}\nAge : {age}";
    }

    public static void SumAndProduct(int a, int b, out int sum, out int product)
    {
      sum = Solution.Sum(a, b);
      product = a * b;
    }

    public static (int quotient, int remainder) QuotientAndRemainder(int a, int b)
    {
      return (
        a / b,
        a % b
      );
    }

    public static int MethodWithDefaultValue(int number = 10){
      return number * 2;
    }
  }
}