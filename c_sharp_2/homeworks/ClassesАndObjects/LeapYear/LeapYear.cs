using System;

namespace LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            string year = Console.ReadLine();
            if (DateTime.IsLeapYear(int.Parse(year)))
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
