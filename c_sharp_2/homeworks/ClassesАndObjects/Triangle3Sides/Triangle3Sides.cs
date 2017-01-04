using System;

namespace Triangle3Sides
{
    class Triangle3Sides
    {
        static void Main()
        {
            Triangle triangle = new Triangle();
            triangle.Side1 = double.Parse(Console.ReadLine());
            triangle.Side2 = double.Parse(Console.ReadLine());
            triangle.Side3 = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", triangle.Area());
        }
        public class Triangle
        {
            private double side1;
            private double side2;
            private double side3;

            public double Side1
            {
                get
                {
                    return side1;
                }
                set
                {
                    side1 = value;
                }
            }
            public double Side2
            {
                get
                {
                    return side2;
                }
                set
                {
                    side2 = value;
                }
            }
            public double Side3
            {
                get
                {
                    return side3;
                }
                set
                {
                    side3 = value;
                }
            }

            public double Area()
            {
                double area = 0d;
                double p = (side1 + side2 + side3) / 2;
                area = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
                return area;
            }
        }
    }
}
