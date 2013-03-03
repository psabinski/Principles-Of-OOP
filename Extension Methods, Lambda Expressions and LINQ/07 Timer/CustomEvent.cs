﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Timer
{
   

    // Define a class to hold custom event info 
    public class CustomEvent : EventArgs
    {
        public CustomEvent(string s)
        {
            message = s;
        }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }

    
   
}
