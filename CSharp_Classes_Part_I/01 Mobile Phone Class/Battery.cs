using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Mobile_Phone_Class
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCd, Obiknovenna
    }
    
    public class Battery
    {
        private string model;
        private double hours_idle;
        private double hours_talk;
        private BatteryType type;

        public Battery()
            : this("H11A", 10, 2, BatteryType.NiMH)
        {
        }

        public Battery(string model, double hours_idle, double hours_talk, BatteryType type)
        {
            this.model = model;
            this.hours_idle = hours_idle;
            this.hours_talk = hours_talk;
            this.type = type;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model can not be empty");
                }
                if (value.Length > 20)
                {
                    throw new ArgumentException("The entry sholul be less then 20 symbols");
                }

                this.model = value;
            }

        }

        public double Standby
        {
            get { return this.hours_idle; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The value should be positive number");
                }
                this.hours_idle = value;
            }
        }

        public double TalkReadyness
        {
            get { return this.hours_talk; }
            set { this.hours_talk = value; }
        }

        public BatteryType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

    }
}
