using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DuplicateProductNumber : Exception
    {
        public DuplicateProductNumber() 
            : base("That product number already exists")
        {  }

        public DuplicateProductNumber(string message)
        {  }

        public DuplicateProductNumber(string message, Exception inner) 
            : base(message, inner) 
        {  }

    }
}
