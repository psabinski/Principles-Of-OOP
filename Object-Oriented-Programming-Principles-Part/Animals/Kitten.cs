using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Kitten : Cat, ISound
    {
       
        
        public Kitten(int age, Sex sex=Sex.Fimale)
            : base(age, sex) { }

        public void ProduceSound()
        {
            Console.WriteLine("Miauuuu");
        }
        
    }
}
