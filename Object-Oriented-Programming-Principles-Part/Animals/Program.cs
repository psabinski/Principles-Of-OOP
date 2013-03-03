using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define 
//useful constructors and methods. Dogs, frogs and cats are Animals.
//All animals can produce sound (specified by the ISound interface).
//Kittens and tomcats are cats. All animals are described by age, name and sex.
//Kittens can be only female and tomcats can be only male. Each animal produces 
//a specific sound. Create arrays of different kinds of animals and calculate the 
//average age of each kind of animal using a static method (you may use LINQ).


namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructors test
            
            Kitten kity = new Kitten(10);

            Console.WriteLine("Kity's sex is : " + kity.Sex);

            Tomcat tommy = new Tomcat(10);

            Console.WriteLine("Tommy's sex is : " + tommy.Sex);


            Dog rex = new Dog(10,Sex.Male);

            Console.WriteLine("Rex's sex is : " + rex.Sex);
            Console.WriteLine("And Rex is {0} years old", rex.Age);

            Frog gogo = new Frog(100, Sex.Male);
            Console.WriteLine("Gogo the frog is {0} years old: ", gogo.Age);
         


          
            // Sounds test
            Console.WriteLine("__________________");
            Console.WriteLine("Frogs sound: ");
            gogo.ProduceSound();
            Console.WriteLine("__________________");
            Console.WriteLine("Tomcats sound: ");
            tommy.ProduceSound();
            Console.WriteLine("__________________");
            Console.WriteLine("Kittens sound: ");
            kity.ProduceSound();
            Console.WriteLine("__________________");
            Console.WriteLine("Dogs sound: ");
            rex.ProduceSound();

            Console.WriteLine();

            Dog[] dogs = new Dog[4] 
            {
              new Dog(10,Sex.Male),
              new Dog(12,Sex.Male),
              new Dog(14,Sex.Male),
              new Dog(8,Sex.Male),
            };

            Frog[] frogs = new Frog[4]
            {
                new Frog(4,Sex.Male),
                new Frog(5,Sex.Male),
                new Frog(3,Sex.Male),
                new Frog(10,Sex.Male)

            };

            Kitten[] kities = new Kitten[4]
            {
                new Kitten(10),
                new Kitten(11),
                new Kitten(15),
                new Kitten(18)
            };

            Tomcat[] tomcats = new Tomcat[4]
            {
                new Tomcat(12),
                new Tomcat(15),
                new Tomcat(13),
                new Tomcat(40),
            };

            // Avarage age
            Console.WriteLine(" The avarage age of Tomcat is " + AvarageAge(tomcats));
            Console.WriteLine(" The avarage age of Kitten is " + AvarageAge(kities));
            Console.WriteLine(" The avarage age of Dogs is " + AvarageAge(dogs));
            Console.WriteLine(" The avarage age of Frogs is " + AvarageAge(frogs));

            Console.WriteLine();

        }

        public static double AvarageAge(Animal[] animals)
        {
            var query  = animals.Average(x => x.Age);
            return query;          
        }


    }
}
