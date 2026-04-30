using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InsufficientQuantity : Exception
    {

        public InsufficientQuantity()
    : base("There isn't enough products of this type.")
        { }

        public InsufficientQuantity(string message)
        { }

        public InsufficientQuantity(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
