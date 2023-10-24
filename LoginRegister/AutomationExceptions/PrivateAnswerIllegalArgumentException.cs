using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegister.AutomationExceptions
{
    public class PrivateAnswerIllegalArgumentException : Exception
    {
        public PrivateAnswerIllegalArgumentException(string message) : base(message)
        {

        }

    }
}
