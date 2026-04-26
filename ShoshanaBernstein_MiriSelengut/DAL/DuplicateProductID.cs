using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DuplicateProductID : Exception
    {
        public DuplicateProductID() 
            : base("That Product ID already exists")
        {  }

        public DuplicateProductID(string message)
        {  }

        public DuplicateProductID(string message, Exception inner) 
            : base(message, inner) 
        {  }

    }
}
