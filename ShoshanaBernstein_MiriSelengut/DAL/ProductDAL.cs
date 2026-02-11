using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {
        static List<Product> list = new List<Product>();

        #region Ctor
        //ctor that initiales list to data in the text file
        public ProductDAL()
        {
             InitializeList();
        }
        #endregion

        #region InitializeList
        //initializes the list to the information in the text file
        public void InitializeList()
        {
            string[] lines = File.ReadAllLines(@"..\..\DAL\ProductList.txt");
            var index = 0;

            //for each line in the file create a new object
            foreach (string line in lines)
            {
                
                string[] parts = line.Split(' ');
                int productNumber = int.Parse(parts[0]);
                string productName = parts[1];
                float costPerUnit = float.Parse(parts[2]);
                int amountInStock = int.Parse(parts[3]);
                
                Product newproduct = new Product(productNumber, productName, costPerUnit, amountInStock);

                //add the objects to the list
                list.Add(newproduct);
            }
           
        }
        #endregion

        #region Create
        //method to add a new object to list
        public void Create(Product tmp)
        {
            //Check if a product with the same ProductNumber already exists
            bool exists = list.Any(p => p.ProductNumber == tmp.ProductNumber);
            //if it doesn't exit
            if (!exists)
            {
                Product newProduct = new Product(
                    tmp.ProductNumber,
                    tmp.ProductName,
                    tmp.CostPerUnit,
                    tmp.AmountInStock
                    );

                //add it to the list
                list.Add(newProduct);
            }

        }
        #endregion

        #region Read all the list
        //method to return the entire list

        public List<Product> Read()
        {
            //create a new list
            List<Product> newList = new List<Product>();

            //for each object in list, copy it
            foreach (Product product in list)
            {
                Product copyProduct = new Product(
                    product.ProductNumber,
                    product.ProductName,
                    product.CostPerUnit,
                    product.AmountInStock
                    );
                
                //add the copied object to newList
                newList.Add(copyProduct);
            }

            return newList;

        }
        #endregion

        #region Update
        //method Update to change some values of a Person

        public void Update(Product tmp)
        {
          
            //go through the list to find the matching product number
            for( int index = 0; index < list.Count(); index++)
            {
                //if the match, create a new object and replace the found object
                if (list[index].ProductNumber == tmp.ProductNumber)
                {
                    Product changedProduct = new Product(tmp.ProductNumber, tmp.ProductName, tmp.CostPerUnit, tmp.AmountInStock);
                    list[index] = changedProduct;
                }
            }

        }
        #endregion

        #region Delete
        // method to Delete a product from the list
        public void Delete(Product tmp)
        {
            //go thru list to find product whose number matches the number of Person parameter
            for(int index = 0; index < list.Count();index++)
            {
                //if the products numbers match
                if (list[index].ProductNumber == tmp.ProductNumber)
                {
                    //remove the object from the list
                    list.RemoveAt(index);
                    break;
                }
            }
        }
        #endregion
    }
}
