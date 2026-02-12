using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    // A class to create objects for each Customer. Inherets from Person.
    public class Customer : Person
    {
        CreditCard creditCard;
        public Customer(string Name, int ID) 
            :base (Name, ID)
        {
            
        }

        public override string ToString()
        {
            return $"Name: {Name}, ID: {ID}";
        }
    }
}
