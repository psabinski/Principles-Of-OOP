using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2 Add a private static read-only field to hold the
// start of the coordinate system – the point O{0, 0, 0}. 
// Add a static property to return the point O.


//3 Write a static class with a static method to calculate
//the distance between two points in the 3D space.

namespace _01_Point_3D
{
    struct Point3D
    {
        
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }
            private static int X0 = 0;
            private static int Y0 = 0;
            private static int Z0 = 0;

           

           

     public Point3D(int X, int Y, int Z)  : this()
	 {
		this.X = X;
		this.Y = Y;
		this.Z = Z;
	 }

     public static string ZeroPoint
     {
         get { return X0 + "," + Y0 + "," + Z0; }
     }

      

        public override string ToString()
        {
            return 

            String.Format("{0},{1},{2} ", this.X, this.Y, this.Z);

        }

        //Write a static class with a static method to calculate
        //the distance between two points in the 3D space.

        public static double Distance(Point3D p1, Point3D p2)
        {
            return Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y) + (p2.Z - p1.Z) * (p2.Z - p1.Z));
           
        }

    }
}
