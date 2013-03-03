using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animal, ISound
    {
         
        public Dog(int age, Sex sex)
            : base(age, sex) { }

        public void ProduceSound()
        {
            Console.WriteLine("Wow wow");
        }
    }
}
