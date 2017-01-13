using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class StartUp
    {
        static void Main()
        {
            //tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.
            Shape[] figuresArray =
                {
                    new Triangle(5, 10),
                    new Rectangle(6, 11),
                    new Square(8, 8)
                };

            foreach (Shape shape in figuresArray)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
