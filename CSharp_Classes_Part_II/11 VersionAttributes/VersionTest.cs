using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_VersionAttributes
{
    [Version_Attributes("2.11")]
    [Version_Attributes("Beta")]

    class VersionTest
    {
        static void Main(string[] args)
        {

            Type type = typeof(VersionTest);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (Version_Attributes versionAttribute in allAttributes)
            {
                Console.WriteLine("This class version is:  {0}. ",
                    versionAttribute.Version);
            }

           var r = type.GetMethod("Echo").Attributes;

            Console.WriteLine(r);

            object[] r1 = type.GetMethod("Echo").GetCustomAttributes(true);

           

        }

        [Version_Attributes("111.12")]
        [Version_Attributes("AAAAAA")]
        public static void Echo()
        {
            Console.WriteLine("Hello");
        }
    }
      
}
