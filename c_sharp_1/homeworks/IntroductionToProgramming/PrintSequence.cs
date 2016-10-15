using System;


namespace PrintLongSequence
{
    class PrintSequence
    {
        static void Main()
        {
            int x;
            for (x = 2; x < 12; x++)
            {
                if (x%2==0)
                {
                    Console.WriteLine(x);
                }

                else
                {
                    Console.WriteLine("-"+x);
                }
            }
        }
    }
}
