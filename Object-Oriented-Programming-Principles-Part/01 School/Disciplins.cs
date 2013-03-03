using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    //Disciplines have name, number of lectures and number of exercises. 
    //Optional comment
    
    class Disciplins : School
    {
        private string name;
        private int numOfLectures;
        private int numOfExercises;
      
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int NumOfLectures
        {
            get { return this.numOfLectures; }
            set { this.NumOfLectures = value; }
        }

        public int NumOfExercises
        {
            get { return this.numOfExercises; }
            set { this.numOfExercises = value; }
        }

      
        
        public Disciplins(string name, int numOfLectures, int numOfExercises) 
            : this(name, numOfLectures,  numOfExercises, null)
        {
        }

        public Disciplins(string name, int numOfLectures, int numOfExercises, string comment) 
            : base(comment)
        {
            this.name = name;
            this.numOfLectures = numOfLectures;
            this.numOfExercises = numOfExercises;
         
        }

        
    }
}
