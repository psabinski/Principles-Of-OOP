using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Tomcat: Animal , ISound
    {
         public Tomcat(int age, Sex sex=Sex.Male)
            : base(age, sex) { }

        

         public void ProduceSound()
         {
             Console.WriteLine("Murrrrrr");
         }
    }
}
