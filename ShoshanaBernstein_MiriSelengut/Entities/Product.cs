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

        public Product(int productNumber, string productName, double costPerUnit)
        {
            this.ProductNumber = productNumber;
            this.ProductName = productName;
            this.CostPerUnit = costPerUnit;
        }
    }
}
