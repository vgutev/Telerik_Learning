using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.RangeExceptions
{
    class StartUp
    {
        static void Main()
        {
            int test1;
            test1 = 200;
            if (test1 < 1 || 100 < test1)
            {
                throw new InvalidRangeException<int>(1, 100);
            }
        }
    }
}
