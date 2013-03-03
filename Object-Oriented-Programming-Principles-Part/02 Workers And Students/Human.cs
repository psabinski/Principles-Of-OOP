using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Define abstract class Human with first name and last name. 

namespace _02_Workers_And_Students
{
     public abstract class Human 
    {
        private string fname;
        private string lname;

        public string FirsiName
        {
            get{return this.fname;}
            set { this.fname = value; }
        }

        public string LastName
        {
            get { return this.lname; }
            set { this.lname = value; }
        }

        public Human(string firstName, string lastName)
        {
            this.fname = firstName;
            this.lname = lastName;
        }



    }
}
