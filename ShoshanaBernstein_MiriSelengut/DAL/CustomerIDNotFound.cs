using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class CustomerIDNotFound : Exception
    {
        public CustomerIDNotFound()
    : base("That customer ID isn't found")
        { }

        public CustomerIDNotFound(string message)
        { }

        public CustomerIDNotFound(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
