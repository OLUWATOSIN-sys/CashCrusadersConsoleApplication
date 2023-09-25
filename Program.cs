using System;

namespace CharacterCountAndStringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string input = Console.ReadLine();

            Console.Write("Input character: ");
            char targetChar = Console.ReadLine()[0]; 

            int charCount = CountCharacterOccurrences(input, targetChar);
            string reversedString = ReverseString(input);

            Console.WriteLine($"Occurrences of '{targetChar}' in the input string: {charCount}");
            Console.WriteLine("Reversed input string: " + reversedString);
        }

        static int CountCharacterOccurrences(string input, char targetChar)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == targetChar)
                {
                    count++;
                }
            }
            return count;
        }

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
