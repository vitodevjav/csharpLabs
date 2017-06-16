using System;

namespace CSTheFifthLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            View view = new View();
            while (true) { 
            view.Read();
            }
        }
    }
}