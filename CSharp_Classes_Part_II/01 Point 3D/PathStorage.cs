using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Create a static class PathStorage with static methods to save and 
//load paths from a text file. Use a file format of your choice.

namespace _01_Point_3D
{
    class PathStorage
    {
        
               
        static TextReader input = Console.In;
        static TextWriter output = Console.Out;

        public static void LoadPath(string src, Path p) // load path
        {
            input = File.OpenText(src);

            string line = input.ReadLine(); // first line

            while (line != null)
            {
                string[] currentPoint = line.Split(',');

                p.CurrentPath.Add(
                        new Point3D(
                        int.Parse(currentPoint[0]),
                        int.Parse(currentPoint[1]),
                        int.Parse(currentPoint[2])
                        )
                    );
                line = input.ReadLine(); // next line .. until the end of the text file is reached
            }
            input.Close();
          
        }

        public static void SavePath(string src, Path p)
        {
            output = File.CreateText(src);

            foreach (var point in p.CurrentPath)
            {
                output.WriteLine(point);
            }

            output.Close();
        }
    }
}
