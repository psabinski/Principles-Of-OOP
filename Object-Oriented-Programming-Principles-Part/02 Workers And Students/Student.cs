using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////Define new class Student which is derived from Human and has new field – grade. 

namespace _02_Workers_And_Students
{
    public class Student : Human, IComparable<Student>
    {
        private double grade;

        public double Grade 
        {
            get { return this.grade; }
            set{ this.grade= value; }
        }

        public Student(double grade, string firstName, string lastName) : base(firstName, lastName)
        {
            this.grade = grade;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} - Grade: {2}", this.FirsiName, this.LastName, this.Grade);
        }

        public int CompareTo(Student that)
        {
            if (this.Grade > that.Grade) return -1;
            if (this.Grade == that.Grade) return 0;
            return 1;
        }
    }
}
