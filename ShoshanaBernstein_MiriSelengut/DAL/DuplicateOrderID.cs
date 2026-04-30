using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DuplicateOrderID : Exception
    {
        public DuplicateOrderID()
    : base("That order ID already exists")
        { }

        public DuplicateOrderID(string message)
        { }

        public DuplicateOrderID(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
