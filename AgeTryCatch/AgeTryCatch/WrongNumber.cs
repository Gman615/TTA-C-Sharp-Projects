using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeTryCatch
{
    public class WrongNumber : Exception
    {
        public WrongNumber()
            : base() { }
        public WrongNumber(string message)
            : base(message) { }
    }
}
