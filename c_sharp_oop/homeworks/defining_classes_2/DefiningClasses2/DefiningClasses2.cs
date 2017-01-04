using System;

namespace DefiningClasses2
{
    [Version(2, 6)]
    class DefiningClasses2
    {
       
        static void Main(string[] args)
        {
            Type type = typeof(DefiningClasses2);
            object[] attributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute versionAttribute in attributes)
            {
                Console.WriteLine("Version: {0}.{1}", versionAttribute.Major, versionAttribute.Manor); ;
            }
            Point3D point1 = new Point3D(2, 3, 5);
            Point3D point2 = new Point3D(6, 22, 100);
            ToString(point1);
            ToString(point2);
            Console.WriteLine(PointCalc.DistanceBetweenPoints(point1, point2));
            Console.WriteLine();

            Path path1 = new Path();
            path1.AddPoint(point1);
            path1.AddPoint(point2);
            for (int i = 0; i < path1.Path1.Count; i++)
            {
                ToString(path1.Path1[i]);
            }

            Path path2 = new Path();
            path2 = PathStorage.LoadPath("path_file_1.txt");
            for (int i = 0; i < path2.Path1.Count; i++)
            {
                ToString(path2.Path1[i]);
            }

            PathStorage.SavePath(path1, "path_file_2.txt");

            GenericList<int> genTest = new GenericList<int>(2);
            genTest.AddElement(2);
            genTest.AddElement(8);
            genTest.AddElement(4);
            genTest.AddElement(1);
            genTest.RemoveElement(2);
            genTest.FindElement(8);
            genTest.GetElement(0);
            genTest.InsertElement(5, 1);
            genTest.Min();
            genTest.Max();
        }
        
        public static void ToString(Point3D point)
        {
            Console.WriteLine("X: {0}\nY: {1}\nZ: {2}\n", point.X, point.Y, point.Z);
        }
    }
}
