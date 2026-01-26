using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    // A class to create objects for each Customer. Inherets from Person.
    internal class Customer : Person
    {
        private int creditCard;
        public Customer(string Name, int ID) :base (Name, ID)
        {
            
        }
    }
}
