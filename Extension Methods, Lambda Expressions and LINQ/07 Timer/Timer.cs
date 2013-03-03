using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// 7.Using delegates write a class Timer that 
// can execute certain method at each t seconds.


namespace _07_Timer
{
    public delegate void Delegate();
    
    class Timer
    {
        static int count =0;

        static void Print()
        {
            count++;
            Console.WriteLine("The method was executed " + count + " times");
        }
        static void TimerFunc(Delegate d, int miliseconds, int numOfEexcutions)
        {
            
            for (int i = 0; i < numOfEexcutions; i++)
            {
                Thread.Sleep(miliseconds);
                d(); 
             

                Publisher pub1 = new Publisher();
                Subscriber sub1 = new Subscriber("Subscriber", pub1);

                pub1.Notification();
                
            }
        }

        static void Main(string[] args)
        {
            Delegate d = new Delegate(Print);

            TimerFunc(d, 1000, 10);

            Console.WriteLine();


         

        }
    }
}
