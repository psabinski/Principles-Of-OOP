using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Timer
{
    class Subscriber
    {
        private string id;
        public Subscriber(string ID, Publisher pub)
        {
            id = ID;
            // Subscribe to the event
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        // Define what actions to take when the event is raised. 
        void HandleCustomEvent(object sender, CustomEvent e)
        {
            Console.WriteLine(id + " has new massage: {0}", e.Message);
        }
    }
}
