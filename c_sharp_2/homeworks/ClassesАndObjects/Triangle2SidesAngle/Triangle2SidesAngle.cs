using System;

namespace Triangle2SidesAngle
{
    class Triangle2SidesAngle
    {
        static void Main()
        {
            Triangle triangle = new Triangle();
            triangle.Side1 = double.Parse(Console.ReadLine());
            triangle.Side2 = double.Parse(Console.ReadLine());
            triangle.Angle = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", triangle.Area());
        }
        public class Triangle
        {
            private double side1;
            private double side2;
            private double angle;

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
            public double Angle
            {
                get
                {
                    return angle;
                }
                set
                {
                    angle = value;
                }
            }

            public double Area()
            {
                double area = 0d;
                double angleRad = angle * Math.PI / 180;
                area = (side1 * side2 * Math.Sin(angleRad)) / 2;
                return area;
            }
        }
    }
}
