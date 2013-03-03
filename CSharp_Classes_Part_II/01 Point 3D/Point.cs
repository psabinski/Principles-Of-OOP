using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} 
// in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point...
// see Point3D.cs



namespace _01_Point_3D
{
    class Point
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D() { X = 3, Y = 5, Z = 3 };
            Point3D p2 = new Point3D() { X = 3, Y = 5, Z = 5 };

            Console.WriteLine("This is a 3D Point :       " +p1);
            Console.WriteLine("This is another 3D Point : " + p2);
         

            Console.WriteLine("The distance between these two points is :" +Point3D.Distance(p1, p2));

            Console.WriteLine();
            Console.WriteLine("Zero Point is : " + Point3D.ZeroPoint);

            Console.WriteLine();

            Path p = new Path(new List<Point3D>()); 

            // loading path from external file
            Console.WriteLine("Loading points from external file.");
            
            PathStorage.LoadPath(@"../../input.txt", p);

            Console.WriteLine();
            Console.WriteLine("Printing Points from the external file.");

            foreach (var point in p.CurrentPath)
            {
                Console.WriteLine(point);
            }
            Console.WriteLine(p.CurrentPath[0]);

            // saving the path to external file

            PathStorage.SavePath(@"../../input.txt", p);

          
        }
    }
}
