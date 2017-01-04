using System;

namespace Triangle
{
    class Triangle
    {
        static void Main()
        {
            Triangle2 triangle = new Triangle2();
            triangle.Side = double.Parse(Console.ReadLine());
            triangle.Altitude = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", triangle.Area());

        }
    }
    public class Triangle2
    {
        private double side;
        private double altitude;

        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }

        public double Altitude
        {
            get
            {
                return altitude;
            }
            set
            {
                altitude = value;
            }
        }
        
        public double Area()
        {
            double area = (side * altitude) / 2;
            return area;
        }
    }

}
