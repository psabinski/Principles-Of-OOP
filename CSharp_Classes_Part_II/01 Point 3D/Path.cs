using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class Path to hold a sequence of points in the 3D space.



namespace _01_Point_3D
{
    class Path
    {
        private List<Point3D> points;

        public Path(List<Point3D> points)
        {
            this.points = points;
        }
        public List<Point3D> CurrentPath
        {
            get { return this.points; }
            set { this.points = value; }
        }
    }
}
