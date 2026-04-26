using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductIDNotFound : Exception
    {
        public ProductIDNotFound()
    : base("That product number isn't found")
        { }

        public ProductIDNotFound(string message)
        { }

        public ProductIDNotFound(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
