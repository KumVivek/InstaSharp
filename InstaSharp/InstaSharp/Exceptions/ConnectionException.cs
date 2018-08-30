using System;
using System.Collections.Generic;
using System.Text;

namespace InstaSharp.Exceptions
{
    public class ConnectionException : BaseException
    {
        public ConnectionException(string message)
            : base(message)
        { }
    }
}
