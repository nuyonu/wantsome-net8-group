using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7ExceptionsLINQ.Exceptions
{
    public class InvalidNumberException : Exception
    {
        public InvalidNumberException(string message) : base(message) { }
    }
}
