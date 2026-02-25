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
        ProductDAL ProductDAL;

        #region Ctor
        public ProductBLL(ProductDAL productDAL)
        {
            this.ProductDAL = productDAL;
        }
        #endregion

        #region Create
        public void Create(Product tmp)
        {
            try
            {
                ProductDAL.Create(tmp);
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Read All
        public List<Product> ReadAll()
        {
            try
            {
                return ProductDAL.ReadAll();

            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Read One
        public Product Read(int productNumber)
        {
            try
            {
                return ProductDAL.Read(productNumber);

            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Update
        public void Update(Product tmp)
        {
            try
            {
                ProductDAL.Update(tmp);

            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Delete
        public void Delete(Product tmp)
        {
            try
            {
                ProductDAL.Delete(Product tmp);

            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
