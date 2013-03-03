using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using _01_Mobile_Phone_Class;
using _08_Call_Class;

/*
Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
 * 
Create an instance of the GSM class.
 * 
Add few calls.
 * 
Display the information about the calls.
 *
Assuming that the price per minute is 0.37 calculate and print the total 
price of the calls in the history.
 * 
Remove the longest call from the history and calculate the total price again.
 * 
Finally clear the call history and print it.
 */


namespace _12_GSM_Call_History_Test
{
    class GSMCallHistoryTEST
    {
        static void Main(string[] args)
        {
            GSM gsm = new GSM("Sony", "Experia",200,"Telerik40",new Battery(),new Display());

            gsm.AddCall(new Call()); // default values ( duration is 100 seconds)
          

            gsm.AddCall(new Call("0889 889 666", 900));
           
            gsm.AddCall(new Call("0889 889 000", 1100));

           
            // Display the information about the calls.
 
            foreach (var call in gsm.CallHistory)
            {
                
                Console.WriteLine(call);
                Console.WriteLine();
             
            }

            //Assuming that the price per minute is 0.37 calculate and print the total 
            //price of the calls in the history.
            // total call duration is 2100 seconds or 35 minutes or 35*0.37 = 12,95$

            Console.WriteLine();
            Console.WriteLine("The total bill of {1} is ${0:0.00}", gsm.CallsBill(0.37), gsm.Owner);

            //Remove the longest call from the history and calculate the total price again.

            int max = Int32.MinValue;
            int index=0;

            // finding the longest call
            
            for (int i = 0; i < gsm.CallHistory.Count; i++)
            {
                if (gsm.CallHistory[i].Duration > max)
                {
                    max = gsm.CallHistory[i].Duration;
                    index = i;
                }
            }

            // removing the longest call

            gsm.DeleateCall(2);

            // calculate the total price again
            Console.WriteLine();
            Console.WriteLine("The longest call is removed!" );
            Console.WriteLine("The total bill of {1} is ${0:0.00}", gsm.CallsBill(0.37), gsm.Owner);


            //Finally clear the call history and print it.

            gsm.ClearCallHistory();

            // make sure that the histor is cleared .. could be done through the debugger

            foreach (var call in gsm.CallHistory)
            {

                Console.WriteLine(call);
                Console.WriteLine();

            }

        }

    }
}
