using System;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            int x;
            for (x = 2; x < 1002; x++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }

                else
                {
                    Console.WriteLine("-" + x);
                }
            }
        }
    }
}
