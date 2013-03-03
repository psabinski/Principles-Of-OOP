using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Attribute
{
    [Version("2.11")]
    [Version("Beta")]
    class AttributesTests
    {


        static void Main(string[] args)
        {
            Console.WriteLine(99);
            /*
            Type type = typeof(AttributesTests);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute versionAttribute in allAttributes)
            {
                Console.WriteLine("This class version is:  {0}. ",
                    versionAttribute.Version);
            }
             */

             
       
        }
    }
}
