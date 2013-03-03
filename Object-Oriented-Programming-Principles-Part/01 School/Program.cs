using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given a school. In the school there are classes of students. 
//Each class has a set of teachers. Each teacher teaches a set of disciplines.

//Students have name and unique class number. Classes have unique text identifier.

//Teachers have name.

//Disciplines have name, number of lectures and number of exercises. 

//Both teachers and students are people.

//Students, classes, teachers and disciplines could 
//have optional comments (free text block).

//Your task is to identify the classes (in terms of  OOP) and their
//attributes and operations, encapsulate their fields, define the class hierarchy and 
//create a class diagram with Visual Studio.

namespace _01_School
{
    class Program
    {
        static void Main(string[] args)
        {
            Disciplins discipline = new Disciplins("Math", 10, 1000, "Haeavy Duty Discipline");

            Console.WriteLine("Discipline: {0} \nComment: {1}", discipline.Name, discipline.Comment);
            Console.WriteLine();

            Teacher teacher = new Teacher("g-n Telerikov", new List<Disciplins>(), "Goliama gad");

            Console.WriteLine("Teacher: {0} \nComment: {1}", teacher.Name, teacher.Comment);
            Console.WriteLine();

            Class1 class1 = new Class1("5-A", new List<Teacher>(), "Samo dvoikadjii");


            Console.WriteLine("Class: {0} \nComment: {1}", class1.ClassID, class1.Comment);
            Console.WriteLine();


            Student student = new Student("5-A", "Gosko", "Goliam zubur");

            Console.WriteLine("Student: {0} \nComment: {1}", student.Name, student.Comment);
            Console.WriteLine();

            teacher.ListOfDisciplines.Add(discipline); 
            Console.WriteLine(teacher.ListOfDisciplines[0].Name);
        }
    }
}
