using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.RangeExceptions
{
    public class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(T start, T end, string message = null) : base(message)
        {
            Console.WriteLine("Invalid range exception. Input value shoudl be between {0} and {1}!", start, end);
        }
    }
}
