using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Mobile_Phone_Class
{
    public class Display
    {
        private int numOfColors;
        private double size;

        public int NumOfColors
        {
            get { return this.numOfColors; }
            set
            {
                if (value <= 100)
                {
                    throw new ArgumentException("The value shoud be greater then 100");
                }
                this.numOfColors = value;
            }

        }
        public double Size
        {
            get { return this.size; }
            set
            {
                if (value > 5 && value < 2.1)
                {
                    throw new ArgumentException("Incorrect entry! The dsiplay size should be between 5 and 2.1 inches");
                }
                this.size = value;
            }

        }

        public Display()
        {
        }

        public Display(int numOfColors, double size)
        {
            this.size = size;
            this.numOfColors = numOfColors;
        }


    }
    

}
