using System;

namespace DefiningClasses2
{
    [Version(2, 6)]
    public struct Point3D
    {
        private static readonly Point3D o = new Point3D(0, 0, 0);

        public static Point3D O { get { return o; } }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
