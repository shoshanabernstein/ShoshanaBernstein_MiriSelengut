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

            Product couch = new Product(1, "couch", 500.98, 20);

            // Adds couch
            productBLL.Create(couch);
            Console.WriteLine(productBLL.ReadAll());

            //productBLL.Update(couch);
            //Console.WriteLine(productBLL.ReadAll());


            //productBLL.Delete(couch);
            //Console.WriteLine(productBLL.Read(couch.ProductNumber));

        }
    }
}
