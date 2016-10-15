using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double eps = 0.000001f;
            double firstNumber;
            double secondNumber;
            double error;
            
            firstNumber = double.Parse(Console.ReadLine());
            secondNumber = double.Parse(Console.ReadLine());
            error = firstNumber - secondNumber;

            if (error < 0) error = -error;
            if (error < eps)
                Console.WriteLine("true");
            else
                Console.WriteLine("false"); 


        }
    }
}
