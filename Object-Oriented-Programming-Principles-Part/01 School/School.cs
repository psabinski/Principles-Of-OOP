using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    public class School
    {
        private string comment;

        public string Comment
        {
            get{ return this.comment;}
            set { this.comment = value; }
        }

        public School()
        {
        }
        
        public School(string comment)
        {
            this.comment = comment;
        }
        
        
    }
}
