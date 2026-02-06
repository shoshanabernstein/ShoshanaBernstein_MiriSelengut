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
        public ProductDAL()
        {
             
        }
        #endregion

        #region InitializeList
        public void InitializeList()
        {
            string[] lines = File.ReadAllLines(@"..\..\DAL\ProductList.txt");
            var index = 0;

            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');

                string productNumber = parts[0];
                string productName = parts[1];
                float costPerUnit = float.Parse(parts[2]);
                int amountInStock = int.Parse(parts[3]);

               

            }
           
        }
        #endregion

        #region Create

        #endregion
    }
}
