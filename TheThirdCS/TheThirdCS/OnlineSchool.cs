using System;
using System.Collections.Generic;
using System.Text;

namespace TheThirdCS
{
    delegate void WI();

    class OnlineSchool
    {
        public event WI newWebinar;    

        public void onNewWebinar()
        {
            Console.WriteLine("Event has been created\n");
            newWebinar();
        }
        
    }
}
