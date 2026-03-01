using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    // A class to create objects for each Product.
    public class Product
    {
        // Number of product
        public int ProductNumber { get; set; }

        // Name of product
        public string ProductName { get; set; }

        // Product's cost per unit
        public double CostPerUnit { get; set; }

        // Amount of product in stock
        public int AmountInStock { get; set; }

        public Product(int ProductNumber, string ProductName, double CostPerUnit, int AmountInStock)
        {
            this.ProductNumber = ProductNumber;
            this.ProductName = ProductName;
            this.CostPerUnit = CostPerUnit;
            this.AmountInStock = AmountInStock;
        }

        public override string ToString()
        {
            return "Name: " + ProductName + "\nNumber: " + ProductNumber + "\nCost per unit: " + CostPerUnit + "\nAmount in stock: " + AmountInStock;
        }
    }
}
