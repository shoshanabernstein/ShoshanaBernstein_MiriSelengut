using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Product
    {
        public int ProductNumber { get; set; }
        public string ProductName { get; set; }
        public double CostPerUnit { get; set; }

        public Product(int ProductNumber, string ProductName, double CostPerUnit)
        {
            this.ProductNumber = ProductNumber;
            this.ProductName = ProductName;
            this.CostPerUnit = CostPerUnit;
        }
    }
}
