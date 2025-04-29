using System;
using System.Linq.Expressions;

namespace Variables
{
    public class Solution
    {
        public static string SayHello(string name)
        {
            return $"Hello {name}";
        }

        public static float AgeToFloat(int age){
            float ageToFloat = (float)age;
            return ageToFloat / 2;
        }

        public static decimal CelciusToFarenheit(decimal celsiusTemp){
            decimal celciusToFarenheit = celsiusTemp * (9m / 5m) + 32;
            return celciusToFarenheit;
        }

        public static double KilometersToMiles(double kilometers){
            double kilometersToMiles = kilometers * 0.62137119d;
            return Math.Round(kilometersToMiles, 1);
        }

        public static int RandomNumber(){
            Random random = new Random();
            return random.Next(1, 11);
        }

    }
}