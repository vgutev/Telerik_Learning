using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                double num = double.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new Exception();
                }
                    Console.WriteLine("{0:f3}", Math.Sqrt(num));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
