using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Solution
    {
        public static string IsAdult(int age){
            string reponse = age >= 18 ? "You are an adult": "You are a child";
            return reponse;
        }

        public static string EvenOrOdd(int number){
            string reponse = number%2 == 0 ? "Even": "Odd";
            return reponse;
        }

        public static int Add(int a, int b){
            return a + b;
        }

        public static int Max(int a, int b){
            return Math.Max(a, b);
        }
    }
}