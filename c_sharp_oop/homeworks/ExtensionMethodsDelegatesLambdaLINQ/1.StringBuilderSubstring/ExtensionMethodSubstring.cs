using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StringBuilderSubstring
{
    public static class ExtensionMethodSubstring
    {
        public static StringBuilder Substring(this StringBuilder input, int index)
        {
            StringBuilder result = new StringBuilder();
            for (int i = index; i < input.Length; i++)
            {
                result.Append(input[i]);
            }
            return result;
        }
    }
}
