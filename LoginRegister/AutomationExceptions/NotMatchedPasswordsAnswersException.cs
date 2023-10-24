using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegister.AutomationExceptions
{
    public class NotMatchedPasswordsAnswersException : Exception
    {
        public NotMatchedPasswordsAnswersException(string message) : base(message)
        {

        }

    }
}
