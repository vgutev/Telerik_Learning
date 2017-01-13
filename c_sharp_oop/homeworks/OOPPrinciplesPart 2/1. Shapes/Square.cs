using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    public class Square : Shape
    {
        public Square(double width, double height) : base(width, height)
        {
            if (width != height)
            {
                throw new ArgumentException("Width and height of square must be equal!");
            }
        }

        public override double CalculateSurface()
        {
            double surface;
            surface = this.Width * this.Height;
            return surface;
        }
    }
}
