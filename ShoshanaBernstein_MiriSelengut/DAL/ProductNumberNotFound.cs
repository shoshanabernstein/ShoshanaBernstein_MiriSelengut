using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class ProductNumberNotFound : Exception
    {
        public ProductNumberNotFound()
    : base("That product number isn't found")
        { }

        public ProductNumberNotFound(string message)
        { }

        public ProductNumberNotFound(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
