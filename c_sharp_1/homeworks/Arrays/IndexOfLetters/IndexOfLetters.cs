using System;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            char[] alphabet = new char[26];
            string word = Console.ReadLine();
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)(i + 97);
            }
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        Console.WriteLine(j);
                    }
                }
            }
        }
    }
}
