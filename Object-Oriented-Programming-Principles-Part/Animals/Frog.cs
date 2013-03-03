using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
   
       
    class Frog : Animal, ISound
    {
         
        public  Frog(int age, Sex sex)
            : base(age, sex) { }

        public void ProduceSound()
        {
            Console.WriteLine("Kvak kvak");
        }
    }
}
