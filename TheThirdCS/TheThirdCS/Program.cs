using System;

namespace TheThirdCS
{
    class Program
    {
        static void Main(string[] args)
        {
            OnlineSchool onlineSchool = new OnlineSchool();
            Visitor visitor1 = new Visitor("Jonh ", 21);
            Visitor visitor2 = new Visitor("Mike ", 31);

            onlineSchool.newWebinar += visitor1.EventHandler;
            onlineSchool.newWebinar += visitor1.EventHandler;
            onlineSchool.newWebinar += visitor2.EventHandler;

            onlineSchool.onNewWebinar();

            Console.ReadLine();
        }
    }
}