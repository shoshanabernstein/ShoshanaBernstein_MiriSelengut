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
            #region TestsingOrderBLL

            OrderBLL orderBLL = new OrderBLL();
            ProductDAL productDAL = new ProductDAL();
            Order order = new Order(1, 1, 2);

            Console.WriteLine("\nQuantity before adding");
            Console.WriteLine(productDAL.Read(order.ProductID).AmountInStock);

            Console.WriteLine("\nCreating order");
            orderBLL.Create(order);

            Console.WriteLine("\nQuantity after adding");
            Console.WriteLine(productDAL.Read(order.ProductID).AmountInStock);

            Console.WriteLine("\nRead");
            Console.WriteLine(orderBLL.Read(1));

            Console.WriteLine("\nRead by product");
            Console.WriteLine(orderBLL.ReadProduct(1));

            Console.WriteLine("\nRead by customer");
            Console.WriteLine(orderBLL.ReadCustomer(1));

            Console.WriteLine("\nRead All");
            Console.WriteLine(string.Join("\n", orderBLL.ReadAll()));

            Console.WriteLine("Update");

            Order updateOrder = new Order(order);
            updateOrder.OrderQuantity = 500;
            updateOrder.CustomerID = 1;
            updateOrder.ProductID = 1;

            orderBLL.Update(updateOrder);

            Console.WriteLine("\nQuantity after updating");
            Console.WriteLine(productDAL.Read(order.ProductID).AmountInStock);

            Console.WriteLine("\nDelete");
            orderBLL.Delete(updateOrder);

            Console.WriteLine("\nList after delete");
            Console.WriteLine(string.Join("\n", orderBLL.ReadAll()));
            #endregion
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

            //// ***Testing HW 9***

            //// Create BLL object with DAL dependency
            //CustomerBLL customerBLL = new CustomerBLL();

            //// Adds a customer
            //Customer Sarala = new Customer("Sarala", 101);
            //customerBLL.Create(Sarala);

            //// Print the customer
            //Console.WriteLine("Original Customer");
            //Console.WriteLine(customerBLL.Read(101));
            //Console.WriteLine();

            //// Print all customers (should be empty now)
            //CustomerDAL customers = CustomerDAL.Instance;
            //Console.WriteLine("All Customers");
            //Console.WriteLine(string.Join("\n", customers.ReadAll()));
            //Console.WriteLine();

            //// Update customer (change name)
            //Customer updateSarala = new Customer("Sarala Selengut", 101);
            //customerBLL.Update(updateSarala);

            //// Print updated customer
            //Console.WriteLine("Updated Customer");
            //Console.WriteLine(customerBLL.Read(101));
            //Console.WriteLine();

            //// Delete customer
            //Console.WriteLine("Deleted Customer Sarala");
            //customerBLL.Delete(Sarala); // Delete the original Sarala

            //// Print all customers (should be empty now)
            //Console.WriteLine("All Customers");
            //Console.WriteLine(string.Join("\n", customers.ReadAll()));
            //Console.WriteLine();

            //// ***Testing Exceptions***
            //Console.WriteLine("***Testing Exceptions***");

            //try
            //{
            //    // Create customer with duplicate ID
            //    Customer duplicateAlice = new Customer("Duplicate Alice", 101);
            //    customerBLL.Create(duplicateAlice);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception caught while creating duplicate customer:");
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine();
            //}

            //try
            //{
            //    // Search for customer ID that doesn't exist
            //    customerBLL.Read(999);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception caught while reading non-existent customer:");
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
        }
    }
}
