using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value > 0)
                {
                    this.width = value;
                }
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
            }
        }

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public abstract double CalculateSurface();
    }
}
