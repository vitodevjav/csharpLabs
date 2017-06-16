using System;
using System.Collections.Generic;
using System.Text;

namespace CSTheFourthLab
{
    class Rectangle: Figure, IMovable, IScalable, IInitializable
    {
        public void Initialize()
        {
            arrayX = new int[4];
            arrayY = new int[4];
            readCoordinates();
        }

        public void Move(int dx, int dy)
        {
            for (int i = 0; i < 4; i++)
            {
                arrayY[i] += dy;
                arrayX[i] += dx;
            }
        }

        public void Scale(int kX, int kY)
        {
            for (int i = 1; i < 4; i++)
            {
                arrayX[i] = arrayX[i] + (arrayX[i] - arrayX[0]) * kX;
                arrayY[i] = arrayY[i] + (arrayY[i] - arrayY[0]) * kY;
            }
        }

        private void readCoordinates()
        {
            int x1, y1, x2, y2;
            x1 = Int32.Parse(Console.ReadLine());
            y1 = Int32.Parse(Console.ReadLine());
            x2 = Int32.Parse(Console.ReadLine());
            y2 = Int32.Parse(Console.ReadLine());
            arrayX[0] = x1;
            arrayY[0] = y1;
            arrayX[1] = x2;
            arrayY[1] = y1;
            arrayX[2] = x2;
            arrayY[2] = y2;
            arrayX[3] = x1;
            arrayY[3] = y2;
        }

        public void printCoordinates()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write(arrayX[i] + "  " + arrayY[i]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
