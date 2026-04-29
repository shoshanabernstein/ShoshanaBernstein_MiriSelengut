using DAL;
using System;
using System.Collections.Generic;
using Entities;
using System.Linq;

namespace BLL
{
    public class OrderBLL
    {
        // instance of OrderDAL in BLL 
        private OrderDAL orderDAL;
        public ProductDAL productDAL = new ProductDAL();
        public ProductBLL productBLL;

        #region Ctor
        // BLL ctor creating an object of OrderDAL
        public OrderBLL()
        {
            this.orderDAL = OrderDAL.Instance;
            this.productBLL = new ProductBLL(productDAL);

        }
        #endregion

        #region Create
        // method to create orders (and throw exception otherwise)
        public void Create(Order tmp)
        {
            try
            {
                // making sure product exists
                bool existsProduct = ProductDAL.list.Any(p => p.ProductNumber == tmp.ProductID);
                bool existsCustomer = CustomerDAL.list.Any(p => p.CustomerID == tmp.CustomerID);

                if (existsCustomer)
                {
                    if (existsProduct)
                    {
                        // create new order
                        orderDAL.Create(tmp);

                        //update quantity of product used in order
                        Product createProduct = productDAL.Read(tmp.ProductID);
                        if (createProduct != null)
                        {
                            int newQuantity = createProduct.AmountInStock - tmp.OrderQuantity;
                            productDAL.Update(new Product(createProduct.ProductNumber, createProduct.ProductName, createProduct.CostPerUnit, newQuantity));
                        }


                        return;
                    }
                    throw new ProductIDNotFound();
                }
                throw new CustomerIDNotFound();

            }
            catch (OrderIDNotFound ex)
            {
                Console.WriteLine("\nCaught in Read one in OrderDAL");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Throwing to OrderBLL");
                throw;
            }
        }

        #endregion

        #region Read All
        // method to read all orders in list (and throw exception otherwise)
        public List<Order> ReadAll()
        {
            try
            {
                return orderDAL.ReadAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught in Read All in Order BLL");
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion

        #region Read One
        // method to read order by OrderID (and throw exception otherwise)
        public Order Read(int orderID)
        {
            try
            {
                return orderDAL.Read(orderID);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught in Read in Order BLL");
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion

        #region Read by Customer
        // method to read order by CustomerID (and throw exception otherwise)
        public Order ReadCustomer(int customerID)
        {
            try
            {
                return orderDAL.ReadCustomer(customerID);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught in Read in Order BLL");
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion

        #region Read by product 
        // method to read order by Product ID (and throw exception otherwise)
        public Order ReadProduct(int productID)
        {
            try
            {
                return orderDAL.ReadProduct(productID);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught in Read in Order BLL");
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion

        #region Update
        // method to update orders (and throw exception otherwise)
        public void Update(Order tmp)
        {
            try
            {
                // update the quantity of the product
                Order updateOrder = orderDAL.Read(tmp.OrderID);
                int oldQuantity = updateOrder.OrderQuantity;
                int newQuantity = tmp.OrderQuantity;
                int calculatedQuantity = newQuantity - oldQuantity;

                if (calculatedQuantity != 0)
                {
                    //update quantity of product used in order
                    Product createProduct = productDAL.Read(tmp.ProductID);

                    if (createProduct != null)
                    {
                        int updateQuantity = createProduct.AmountInStock - calculatedQuantity;
                        Product updateProductDAL = new Product(createProduct.ProductNumber, createProduct.ProductName, createProduct.CostPerUnit, updateQuantity);
                        productBLL.Update(updateProductDAL);
                    }
                    Console.WriteLine($"Old: {oldQuantity}, New: {newQuantity}");
                }

                orderDAL.Update(tmp);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught in Update in Order BLL");
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion

        #region Delete
        // method to delete orders (and throw exception otherwise)
        public void Delete(Order tmp)
        {
            try
            {
                orderDAL.Delete(tmp);

                //update quantity of product used in order
                Product createProduct = productDAL.Read(tmp.ProductID);
                int newQuantity = createProduct.AmountInStock + tmp.OrderQuantity;
                productDAL.Update(new Product(createProduct.ProductNumber, createProduct.ProductName, createProduct.CostPerUnit, newQuantity));
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught in Delete in Order BLL");
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion
    }
}