using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace BLL
{
    public class ProductBLL
    {
        // instance of ProductDAL in BLL 
        ProductDAL ProductDAL;

        #region Ctor
        // BLL ctor creating an object of ProductDAL
        public ProductBLL(ProductDAL productDAL)
        {
            this.ProductDAL = productDAL;
        }
        #endregion

        #region Create
        // method to create products (and throw exception otherwise)
        public void Create(Product tmp)
        {
            try
            {
                ProductDAL.Create(tmp);
               
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Caught in create in Product BLL");
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Read All
        // method to read all prodcuts in list (and throw exception otherwise)
        public List<Product> ReadAll()
        {
            return ProductDAL.ReadAll();
           
        }
        #endregion




        #region Read One
        // method to read product number (and throw exception otherwise)
        public Product Read(int productNumber)
        {
            try
            {
                return ProductDAL.Read(productNumber);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught in create in Product BLL");
                Console.WriteLine(ex.Message);
            }
        }
        #endregion




        #region Update
        // method to update products (and throw exception otherwise)
        public void Update(Product tmp)
        {
            try
            {
                ProductDAL.Update(tmp);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught in create in Product BLL");
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Delete
        // method to delete products (and throw exception otherwise)
        public void Delete(Product tmp)
        {
            try
            {
                ProductDAL.Delete(tmp);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught in create in Product BLL");
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
