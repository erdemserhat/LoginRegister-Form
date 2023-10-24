using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegister.AutomationExceptions
{
    public class UsernameIlegalArgumentException : Exception
    {
        public UsernameIlegalArgumentException(string message) : base(message)
        {

        }

    }
}
