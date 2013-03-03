using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Mobile_Phone_Class;

// Write a class GSMTest to test the GSM class:
// Create an array of few instances of the GSM class.
// Display the information about the GSMs in the array.
// Display the information about the static property IPhone4S.


namespace _07_GSM_Test
{
    class GSMTest
    {

        static void Main(string[] args)
        {
            GSM[] phones = new GSM[3]

            { 
            new GSM("Sony", "Xperia",100,"Peso",new Battery(), new Display()),
            new GSM("Nokia", "Lumia",100,"Goso",new Battery(), new Display()),
            new GSM("Samsung", "Galaxy",100,"Telerik4o",new Battery(), new Display())
            };

            foreach (var item in phones)
            {
                Console.WriteLine(item);
                Console.WriteLine();
             
            }
            Console.WriteLine();
            Console.WriteLine(phones[0].iPhone4);
                     
        }
    }
}
