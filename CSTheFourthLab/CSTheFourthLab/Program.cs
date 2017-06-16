using System;

namespace CSTheFourthLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Initialize();
            rect.printCoordinates();
            Triangle tri = new Triangle();
            tri.Initialize();
            tri.printCoordinates();
            rect.Move(10,20);
            rect.printCoordinates();
            tri.Scale(2, 3);
            tri.printCoordinates();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}