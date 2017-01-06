using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StringBuilderSubstring
{
    class StartUp
    {
        static void Main()
        {
            //problem 1. substring extension method test
            StringBuilder strBuild = new StringBuilder();
            strBuild.Append("banan");
            strBuild.Append(" makaron");
            strBuild.Append(" tikva");
            Console.WriteLine(strBuild.Substring(6));
        }
    }
}
