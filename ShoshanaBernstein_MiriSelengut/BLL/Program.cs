using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ***Testing HW 7***
            ProductBLL productBLL = new ProductBLL(new ProductDAL() );

            // Adds couch
            Product couch = new Product(5, "couch", 500.98, 20);
            productBLL.Create(couch);

            // Print updated couch
            Console.WriteLine("Original Couch");
            Console.WriteLine(productBLL.Read(5));
            Console.WriteLine();

            // Update couch 
            Product updateCouch = new Product(5, "couch", 907.78, 20);
            productBLL.Update(updateCouch);

            // Print updated couch
            Console.WriteLine("Updated Couch");
            Console.WriteLine(productBLL.Read(5));
            Console.WriteLine();

            // Delete couch 
            productBLL.Update(couch);


            // Print all products
            ProductDAL products = new ProductDAL();
            Console.WriteLine("All Products");
            Console.WriteLine(string.Join("\n", products.ReadAll()));
            //where ReadAll( ) is a method from that gets all the Products

        }
    }
}
