using System;
using System.Collections.Generic;
using System.Text;

namespace CSTheFifthLab
{
    class IncorrectDataException: FormatException
    {
        public IncorrectDataException(String message):base(message)
        {
           
        }
    }
}
