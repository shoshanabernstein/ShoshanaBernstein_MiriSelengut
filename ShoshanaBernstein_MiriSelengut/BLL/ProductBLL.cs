using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class ProductBLL
    {
        ProductDAL objdal = new ProductDAL();

        // Not sure what we are supposed to do here...
        #region Read all
        public List<Product> GetProducts()
        {
            try
            {
                return objdal;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Read one
        public List<Product> GetProdcu
    }
}
