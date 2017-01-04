using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ReplaceTags
{
    class ReplaceTags
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Regex.Replace(input, "<a href=\"(.*?)\">(.*?)</a>", "[$2]($1)"));
        }
    }
}
