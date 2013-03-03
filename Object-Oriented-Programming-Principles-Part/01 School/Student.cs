using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    //Students have name and unique class number
    //Optional -comment- field
    
    public class Student: People
    {
        private string classID;
    

        public string ClassID
        {
            get { return this.classID; }
            set { this.classID = value; }
        }

        

        internal Student(string fNum, string name) : this(fNum, name, null)
        {
        }

        internal Student(string fNum, string name, string comment) : base(name,comment)
        {
            this.classID = fNum;
            
        }





    }
}
