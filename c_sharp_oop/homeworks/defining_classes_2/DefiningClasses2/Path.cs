using System;
using System.Collections.Generic;

namespace DefiningClasses2
{
    class Path
    {
        private List<Point3D> path = new List<Point3D>();

        public List<Point3D> Path1 { get { return path; } }

        public void AddPoint(Point3D point)
        {
            path.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            path.Remove(point);
        }
        
    }
}
