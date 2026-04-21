using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
using BLL;

namespace BLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Testing Product BLL
            //// ***Testing HW 7***
            //ProductBLL productBLL = new ProductBLL(new ProductDAL());

            //// Adds couch
            //Product couch = new Product(5, "couch", 500.98m, 20);
            //productBLL.Create(couch);

            //// Print updated couch
            //Console.WriteLine("Original Couch");
            //Console.WriteLine(productBLL.Read(5));
            //Console.WriteLine();

            //// Update couch 
            //Product updateCouch = new Product(5, "couch", 907.78m, 20);
            //productBLL.Update(updateCouch);

            //// Print updated couch
            //Console.WriteLine("Updated Couch");
            //Console.WriteLine(productBLL.Read(5));
            //Console.WriteLine();

            //// Delete couch 
            //productBLL.Update(couch);


            //// Print all products
            //ProductDAL products = new ProductDAL();
            //Console.WriteLine("All Products");
            //Console.WriteLine(string.Join("\n", products.ReadAll()));
            ////where ReadAll( ) is a method from that gets all the Products

            //// Testing Exeptions
            //Console.WriteLine("\n***Testing Exeptions***");

            //// Create object with the same productid 
            //Product copyCouch = new Product(5, "copy couch", 907.78m, 20);
            //productBLL.Create(copyCouch);

            //// Search for productid that doesn't exist
            //productBLL.Read(12);
            #endregion
            #region Testing CustomerBLL

            // ***Testing HW 9***

            // Create BLL object with DAL dependency
            CustomerBLL customerBLL = new CustomerBLL();

            // Adds a customer
            Customer Sarala = new Customer("Sarala", 101);
            customerBLL.Create(Sarala);

            // Print the customer
            Console.WriteLine("Original Customer");
            Console.WriteLine(customerBLL.Read(101));
            Console.WriteLine();

            // Print all customers (should be empty now)
            CustomerDAL customers = CustomerDAL.Instance;
            Console.WriteLine("All Customers");
            Console.WriteLine(string.Join("\n", customers.ReadAll()));
            Console.WriteLine();

            // Update customer (change name)
            Customer updateSarala = new Customer("Sarala Selengut", 101);
            customerBLL.Update(updateSarala);

            // Print updated customer
            Console.WriteLine("Updated Customer");
            Console.WriteLine(customerBLL.Read(101));
            Console.WriteLine();

            // Delete customer
            Console.WriteLine("Deleted Customer Sarala");
            customerBLL.Delete(Sarala); // Delete the original Sarala

            // Print all customers (should be empty now)
            Console.WriteLine("All Customers");
            Console.WriteLine(string.Join("\n", customers.ReadAll()));
            Console.WriteLine();

            // ***Testing Exceptions***
            Console.WriteLine("***Testing Exceptions***");

            try
            {
                // Create customer with duplicate ID
                Customer duplicateAlice = new Customer("Duplicate Alice", 101);
                customerBLL.Create(duplicateAlice);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught while creating duplicate customer:");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

            try
            {
                // Search for customer ID that doesn't exist
                customerBLL.Read(999);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught while reading non-existent customer:");
                Console.WriteLine(ex.Message);
            }
            #endregion 
        }
    }
}
