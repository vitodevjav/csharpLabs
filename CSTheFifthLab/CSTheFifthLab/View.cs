using System;
using System.Collections.Generic;
using System.Text;

namespace CSTheFifthLab
{
    public class View
    {
        public void Read()
        {
            String data = Console.ReadLine();
            TryCount(data);
        }

        private void TryCount(String data)
        {
            try
            {
                Calculator.Count(this , data);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IncorrectDataException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IncorrectOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Write(double result)
        {
            Console.WriteLine("=" + result);
        }
    }
}
