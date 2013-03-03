using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_Call_Class;

//1. Define a class that holds information about a mobile phone device:
//model, manufacturer, price, owner, battery characteristics
//(model, hours idle and hours talk) and display characteristics 
//(size and number of colors). Define 3 separate classes 
//(class GSM holding instances of the classes Battery and Display).


//2. Define several constructors for the defined classes that take different 
//sets of arguments (the full information for the class or part of it).
//Assume that model and manufacturer are mandatory (the others are optional). 
//All unknown data fill with null.

//3.  Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) 
//and use it as a new field for the batteries

//4. Add a method in the GSM class for displaying all 
//information about it. Try to override ToString().

//5. Use properties to encapsulate the data fields inside the 
//GSM, Battery and Display classes. Ensure all fields hold correct data at any given time.

//6. Add a static field and a property IPhone4S in 
//the GSM class to hold the information about iPhone 4S.

//9 Add a property CallHistory in the GSM class to hold a 
//list of the performed calls. Try to use the system class List<Call>.

//10 Add methods in the GSM class for adding and deleting calls
//from the calls history. Add a method to clear the call history.

//Add a method that calculates the total price of the calls in the 
//call history. Assume the price per minute is fixed and is provided as a parameter.



namespace _01_Mobile_Phone_Class
{

    public class GSM
    {

        private List<Call> callHistory = new List<Call>();
        
        private string vendor;
        private string model;
        private double price;
        private string owner;
        private Battery battery= new Battery();
        private Display display= new Display();
        private static string iphone = @"iPhone info: 
UMTS/HSDPA/HSUPA (850, 900, 1900, 2100 MHz); 
GSM/EDGE (850, 900, 1800, 1900 MHz)
CDMA EV-DO Rev. A (800, 1900 MHz)3
802.11b/g/n Wi-Fi (само 802.11n 2,4GHz)
Безжична технология Bluetooth 4.0

Retina дисплей
3,5 инча (по диагонал) широкоекранен Multi-Touch дисплей
Разделителна способност 960x640 пиксела при 326 ppi
Контраст 800:1 (стандартно)
Максимална яркост 500 cd/m2 (стандартно)
Предно и задно олеофобично покритие против отпечатъци
Поддръжка на едновременно извеждане на няколко езика и видове знаци
";

        public Battery BatteryInfo
        {
            get { return this.battery; }
            set { this.battery = value; }

        }

        public Display DisplayInfo
        {
            get { return this.display; }
            set { this.display = value; }

        }

        public string Model
        {
            get { return this.model; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The field can not be empty");
                }
                if (value.Length > 20)
                {
                    throw new ArgumentException("The entry sholul be less then 20 symbols");
                }
                this.model = value; 
            }

        }
        public string Vendor
        {
            get { return this.vendor; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The field can not be empty");
                }
                if (value.Length > 20)
                {
                    throw new ArgumentException("The entry sholul be less then 20 symbols");
                }
                this.vendor = value; 
            }

        }
        public double Price
        {
            get { return this.price; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The value shoud be greater then 0");
                }
                this.price = value; 
            }

        }
        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The field can not be empty");
                }
                if (value.Length > 20)
                {
                    throw new ArgumentException("The entry sholul be less then 20 symbols");
                }

                this.owner = value; 
            }

        }
        
        public string iPhone4
        {
            get { return iphone; }
            
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }



        public GSM(string vendor, string model) : this(vendor, model, 0, null, null, null)
        {
        }

        public GSM(string vendor, string model, double price) : this(vendor, model, price, null, null, null)
        {
        }

       
        public GSM(string vendor, string model, double price, string owner, Battery battery, Display display)
        {
            this.vendor = vendor;
            this.model = model;
            this.price = price;
            this.owner = owner;
            this.battery = battery;


        }

        //4. Add a method in the GSM class for displaying all 
        //information about it. Try to override ToString().

        public void PrintInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return string.Format(@"General Info
GSM model: {0}
GSM vendor: {1}
GSM owner: {2}
GSM price: {3}

Battery Info:
Model: {4}
Type: {5}
Talk Time: {6} min
Stendby:  {7} min

Display Info:
Colors: {8}
Size : {9} inches",
this.Model, this.Vendor, this.Owner, this.Price,
this.BatteryInfo.Model, this.BatteryInfo.Type, this.BatteryInfo.TalkReadyness,
this.BatteryInfo.Standby, this.DisplayInfo.NumOfColors, this.DisplayInfo.Size);

        }


        //10 Add methods in the GSM class for adding and deleting calls 
        //from the calls history. Add a method to clear the call history.

        public void AddCall(Call newCall)
        {
            this.CallHistory.Add(newCall);
        }

        public void DeleateCall(int index) // last call // much elegant will be with Stack
        {
            this.CallHistory.Remove(this.CallHistory[index]);
        }
        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        //11. Add a method that calculates the total price of the
        //calls in the call history. Assume the price per minute is fixed and is provided as a parameter.

        public double CallsBill(double pricePerMinute)
        {
            double bill = 0;
            foreach (var item in this.CallHistory)
            {
                bill += item.Duration * (pricePerMinute/60);
            }
            return bill;

        }
    
        
        static void Main(string[] args)
        {
            //SOME TESTS HERE...PLS REFER TO GSMTest.cs
            
            /*
            GSM g = new GSM("Sony","Xperia");
            GSM g1 = new GSM("Sony", "experia", 100, "Peso", new Battery(), new Display());

            g1.BatteryInfo.Type = BatteryType.NiCd;
            g1.DisplayInfo.NumOfColors = 2560000;
            g1.DisplayInfo.Size = 3.5;

            //g1.Model = "";
            //g1.BatteryInfo.Standby = -1;
          
           g1.PrintInfo();
           //g.PrintInfo();
           Console.WriteLine();
           //Console.WriteLine( g1.iPhone4);

           //Console.WriteLine(g1);
           
            // test Call History property

            g1.CallHistory.Add(new Call("+359 889 990 331", 100));
            Console.WriteLine(g1.CallHistory[0]);

            // Adding call method
            g1.AddCall(new Call("+359 889 090 000", 200));

            Console.WriteLine();
            Console.WriteLine(g1.CallHistory[1]); 
            // Remove call method

            g1.DeleateCall(1);

            // to make sure that the element is removed
            Console.WriteLine();
            foreach (var item in g1.CallHistory)
            {
                Console.WriteLine(item);
            }

            g1.ClearCallHistory();
            // the call history is cleared!

            g1.AddCall(new Call("0888 777 888", 1000)); // new entry

            // testing ClearCallHistory();
            Console.WriteLine();

            foreach (var item in g1.CallHistory)
            {
                Console.WriteLine(item);
            }

            g1.AddCall(new Call()); // 100 seconds default duration
            g1.AddCall(new Call("0888 777 888", 1000));  // total 2100 seconds OR 35 minutes

            //testing CallsBill

            Console.WriteLine();

            Console.WriteLine("The total bill of {1} is ${0:0.00}",g1.CallsBill(0.1), g1.Owner); // 0.1 $ per minute OR 3,50 $

*/
        }
         
    }
}
