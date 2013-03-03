using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

//Create a class Call to hold a call performed through a GSM.
//It should contain date, time, dialed phone number and duration (in seconds).


namespace _08_Call_Class
{
    public class Call
    {
        private DateTime date= DateTime.Now;
        private string dialNumber;
        private int duration;    

        public Call() :this("0888 888 888",100)
        {
        }

        public Call( string dialNumber, int duration)
        {
         
            this.dialNumber = dialNumber;
            this.duration = duration;
           
        }

        public DateTime Date
        {
            get { return this.date; }
           
        }

        public string DialNumber 
        {
            get { return this.dialNumber; }
            set { this.dialNumber = value; }
        }
        public int Duration
        {
            get { return this.duration; }
            set { this.duration= value; }
        }

       /*
        public  int CallDuaration(DateTime endTime)
           {
              return duaration = endTime.Second - date.Second; 
           }
        
        */
        public void PrintCallInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return string.Format(@"Last Call Info:
Dialed Number: {0}
Date: {1}
Call Duaration : {2} seconds" , this.DialNumber,this.Date,this.Duration);

        }
             
        
        static void Main(string[] args)
        {
            Call call1 = new Call("+ 359 888 900 222", 200);
           

            Console.WriteLine(call1.Date);

           

            call1.PrintCallInfo(); // test of  PrintCallInfo()

            Console.WriteLine(call1);// works in the same way as PrintCallInfo ?!#@ maikata ..:)

        }
    }
}
