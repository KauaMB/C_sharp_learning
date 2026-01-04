using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { } 
    }
}
