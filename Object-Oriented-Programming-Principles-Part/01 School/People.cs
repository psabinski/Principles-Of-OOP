using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    public class People :School
    {

        private string name;

        public string Name
        {
            get { return this.name; }
            set {this.name = value; }
        }

        public People()
        {
        }
        
        public People(string name)
            : this(name, null)
        {
        }
        
        
        public People(string name, string comment) : base(comment)
        {
            this.name = name;
           
        }

       
    }
}
