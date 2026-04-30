using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    // A class to create objects for each Customer. Inherets from Person.
    public class Customer : Person
    {
        public CreditCard creditCard;
        public string CustomerName { get; set; }  // ✔ property
        public int CustomerID { get; set; }  // ✔ property

        public Customer(string CustomerName, int CustomerID) 
            :base (CustomerName, CustomerID)
        {
            this.CustomerName = CustomerName;
            this.CustomerID = CustomerID;
        }

        public override string ToString()
        {
            return "Name: " + CustomerName + "\nID: "+ CustomerID + "\n\n--------------\n";
        }
    }
}
