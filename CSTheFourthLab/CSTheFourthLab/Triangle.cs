using System;
using System.Collections.Generic;
using System.Text;

namespace CSTheFourthLab
{
    class Triangle: Figure, IMovable, IScalable, IInitializable
    {
        public void Initialize()
        {
            arrayX = new int[3];
            arrayY = new int[3];
            readCoordinates();
        }

        public void Move (int dx, int dy)
        {
            for (int i = 0; i < 3; i++)
            {
                arrayY[i] += dy;
                arrayX[i] += dx;
            }
        }

        public void Scale(int kX, int kY)
        {
            for (int i = 1; i<3; i++)
            {
                arrayX[i] = arrayX[i] + (arrayX[i] - arrayX[0]) * kX;
                arrayY[i] = arrayY[i] + (arrayY[i] - arrayY[0]) * kY;
            }
        }

        private void readCoordinates()
        {
            arrayX[0] = Int32.Parse(Console.ReadLine());
            arrayY[0] = Int32.Parse(Console.ReadLine());
            arrayX[1] = Int32.Parse(Console.ReadLine());
            arrayY[1] = Int32.Parse(Console.ReadLine());
            arrayX[2] = Int32.Parse(Console.ReadLine());
            arrayY[2] = Int32.Parse(Console.ReadLine());
        }

        public void printCoordinates()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(arrayX[i] + "  " + arrayY[i]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
