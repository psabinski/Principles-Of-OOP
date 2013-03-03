using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
   
    public enum Sex
    {
        Male , Fimale
    }
    
    public class Animal
    {
        private int age;
        private Sex sex;

        public Animal(int age, Sex sex)
        {
            this.age = age;
            this.sex= sex;

        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
 
        }

        public Sex Sex
        {
            get { return this.sex; }
            set { this.sex = value; }

        }

      
      
        
    }
}
