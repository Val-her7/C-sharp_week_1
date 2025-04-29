using System.Text.RegularExpressions;

namespace StringChar
{
    public class Solution
    {
        public static string ReversedString(string input)
        {
            if (string.IsNullOrEmpty(input.Trim()))
            {
                throw new ArgumentException("Input string must not be empty");
            }
            int length = input.Length;
            char[] letters = new char[length];
            for (int i = 1; i <= length; i++)
            {
                letters[length - i] = input[i - 1];
            }
            string reversedWord = string.Join("", letters);
            return reversedWord;
        }

        public static string CountVowels(string input)
        {
            if (string.IsNullOrEmpty(input.Trim()))
            {
                throw new ArgumentException("Input string must not be empty");
            }
            int numberOfVowels = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(char.ToLower(input[i])))
                {   
                    numberOfVowels++;
                }
            }
            return $"Number of vowels:{numberOfVowels}";
        }

        public static bool isPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input.Trim()))
            {
                throw new ArgumentException("Input string must not be empty");
            }
            string cleanInput = Regex.Replace(input, @"[^a-zA-Z]", "").ToLower();
            for (int i = 0; i < cleanInput.Length / 2; i++)
            {
                if (!cleanInput[i].Equals(cleanInput[cleanInput.Length - 1 - i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static char FirstNonRepeatingCharacter(string input){
            if (string.IsNullOrEmpty(input.Trim()))
            {
                throw new ArgumentException("Input string must not be empty");
            }
            for(int i = 0; i < input.Length; i++){
                int repeat = 0;
                for(int j = 0; j < input.Length; j ++){
                    if(i != j){
                        if(char.ToLower(input[i]) == char.ToLower(input[j])){
                            repeat ++;
                        }
                    }
                }
                if(repeat == 0){
                    return input[i];
                }
            }
            return '\0';
        }
    }
}