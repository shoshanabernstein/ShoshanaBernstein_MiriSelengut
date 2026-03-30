using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DuplicateCustomerID : Exception
    {
        public DuplicateCustomerID()
            : base("That customer ID already exists")
        { }

        public DuplicateCustomerID(string message)
        { }

        public DuplicateCustomerID(string message, Exception inner)
            : base(message, inner)
        { }

    }
}
