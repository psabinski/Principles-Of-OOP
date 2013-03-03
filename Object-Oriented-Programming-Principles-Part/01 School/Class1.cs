using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{



    //Classes have unique text identifier
    //Each class has a set of teachers
    class Class1: School
    {
        private List<Teacher> teachers= new List<Teacher>();
     
        private string classID;
       

        public string ClassID
        {
            get { return this.classID; }
            set { this.classID = value; }
              
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            set { this.teachers = value; }
        }



        
        internal Class1(string classId, List<Teacher> teachers)
            : this(classId, teachers,  null)
        {
        }
        
        internal Class1(string classId, List<Teacher> teachers, string comment) : base(comment)
        {
            this.classID = classId;
            this.teachers = teachers;

        }


    }
}
