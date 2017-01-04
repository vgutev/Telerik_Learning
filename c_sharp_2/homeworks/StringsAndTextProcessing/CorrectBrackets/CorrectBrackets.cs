using System;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(BracketsCheck(input));
        }
        static string BracketsCheck(string input)
        {
            short left = 0;
            short right = 0;
            string result = "Correct";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    left++;
                }
                if (input[i] == ')')
                {
                    right++;
                }
                if (right > left)
                {
                    result = "Incorrect";
                    return result;
                }
            }
            if (left != right)
            {
                result = "Incorrect";
            }
            return result;
        }
    }
}
