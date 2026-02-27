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

            Product couch = new Product(5, "Couch", 850, 20);
            ProductBLL BLLObject = new ProductBLL(productDAL);

            ProductBLL.Create(couch);
        }
    }
}
