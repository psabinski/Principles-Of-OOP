using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    //Teachers have name
    //Each teacher teaches a set of disciplines
    
    class Teacher: People
  
    {
        private List<Disciplins> listOfDisciplines = new List<Disciplins>();
       

        
        public List<Disciplins>  ListOfDisciplines
        {
            get { return this.listOfDisciplines; }
            set { this.listOfDisciplines = value; }

        }

        

        internal Teacher(string name, List<Disciplins> listOfDisciplines)
            : this(name, listOfDisciplines, null)
        {
        }
        internal Teacher(string name, List<Disciplins> listOfDisciplines, string comment) 
        {
            base.Name = name;
            this.listOfDisciplines = listOfDisciplines;
            base.Comment = comment;

           

        }

        
    }
}

