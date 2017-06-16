using System;
using System.Collections.Generic;
using System.Text;

namespace CSTheFifthLab
{
    class IncorrectOperationException: Exception
    {
        public IncorrectOperationException(String message): base(message)
        {

        }
    }
}
