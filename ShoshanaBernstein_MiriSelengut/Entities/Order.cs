using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        static int OrderCounter = 0;
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public int OrderQuantity { get; set; }
        public int OrderID { get; set; }

        public Order(int ProductID, int CustomerID, int OrderQuantity)
        {
            this.ProductID = ProductID;
            this.CustomerID = CustomerID;
            this.OrderQuantity = OrderQuantity;
            if (OrderCounter == 0)
            {
                OrderCounter = 1;
            }
            else
            {
                OrderCounter++;
            }
            this.OrderID = OrderCounter;


        }

        // copy ctor to fix auto incrementing issue
        public Order(Order other)
        {
            this.OrderID = other.OrderID;
        }

        public override string ToString()
        {
            return "Order ID: " + OrderID + "\nProduct ID: " + ProductID + "\nCustomer ID: " + CustomerID + "\nQuantity: " + OrderQuantity + "\n\n--------------\n";
        }
    }
}

