using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegister.AutomationExceptions
{
    public class EmailIllegalArgumentException : Exception
    {
        public EmailIllegalArgumentException(string message) : base(message)
        {

        }

    }
}
