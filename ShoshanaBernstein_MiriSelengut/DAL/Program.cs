using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ProductDAL products = new ProductDAL();
            Product piano = new Product(4, "piano", 789.78, 34);

            //add object piano to products
            products.Create(piano);
            //print out name of products in list
            Console.WriteLine("Products in list...");
            foreach (Product p in products.Read())
            {
                Console.WriteLine(p.ProductName + " " + p.CostPerUnit);
            }


            //create new paino object
            Product updatedPiano = new Product(4, "upright paino", 789.78, 34);
            //update piano
            products.Update(updatedPiano);
            //print out name of products in list
            Console.WriteLine("\nProducts in list after piano changed to upright piano");
            foreach (Product p in products.Read())
            {
                Console.WriteLine(p.ProductName + " " + p.CostPerUnit);
            }

            //delete piano from products
            products.Delete(piano);
            //print out name of products in list 
            Console.WriteLine("\nProducts in list after piano was deleted...");
            foreach (Product p in products.Read())
            {
                Console.WriteLine(p.ProductName + " " + p.CostPerUnit);
            }

        }
    }
}
