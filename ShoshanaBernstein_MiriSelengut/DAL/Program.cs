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

            // Add object piano to products
            products.Create(piano);

            // Print out name of products in list
            products.Print(products);

            // Create new paino object
            Product updatedPiano = new Product(4, "upright paino", 789.78, 34);

            // Update piano
            products.Update(updatedPiano);

            // Print out name of products in list
            products.Print(products);

            // Print out found product
            Console.WriteLine("\nProduct that was found:");
            Console.WriteLine(products.Read(2));

            // Delete piano from products
            products.Delete(piano);

            // Print out name of products in list 
            products.Print(products);

            // Different way to print out list
            Console.WriteLine("\nNew way to print list.");
            Console.WriteLine(string.Join("\n", products.ReadAll()));

            // Testing exeptions
            Console.WriteLine("\nTesting exceptions:");

            Product bookcase = new Product(4, "Sefarim Shrank", 789.78, 34);
            Product duplicateBookcase = new Product(4, "Second Sefarim Shrank", 789.78, 34);
            Product nullBookcase = new Product(5, "Non-Existent bookcase", 889.99, 20);

            products.Create(bookcase);

            // Try to add a product with a duplicate product number
            try
            {
                products.Create(duplicateBookcase);
            }
            catch (DuplicateProductNumber e)
            {
                Console.WriteLine("*Error because tried to add a product with already used product number");
                Console.WriteLine(e.Message + "\nPlease re-enter the product with a different product number");
            }

            // Try to read a product with a product number that doesn't exist
            try
            {
                products.Read(5);
                Console.WriteLine(products.Read(4));
            }
            catch (ProductNumberNotFound e)
            {
                Console.WriteLine("*Error because tried to read a non-existent bookcase");
                Console.WriteLine(e.Message + "\nPlease try a different product number");
            }

            // Try to update a product with a product number that doesn't exist
            try
            {
                products.Update(nullBookcase);
            }
            catch (ProductNumberNotFound e)
            {
                Console.WriteLine("*Error because tried to update a non-existent bookcase");
                Console.WriteLine(e.Message + "\nPlease try a different product number");
            }

            // Try to delete a product with a product number that doesn't exist
            try
            {
                products.Delete(nullBookcase);
            }
            catch (ProductNumberNotFound e)
            {
                Console.WriteLine("*Error because tried to delete non-existent bookcase");
                Console.WriteLine(e.Message + "\nPlease try a different product number");
            }
        }
    }
}
