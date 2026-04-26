using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderIDNotFound : Exception
    {
        public OrderIDNotFound()
    : base("That Order ID isn't found")
        { }

        public OrderIDNotFound(string message)
        { }

        public OrderIDNotFound(string message, Exception inner)
            : base(message, inner)
        { }

    }
}
