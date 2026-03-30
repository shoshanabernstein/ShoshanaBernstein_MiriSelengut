using DAL;
using System;
using System.Collections.Generic;
using Entities;

namespace BLL
{
    public class CustomerBLL
    {
        // instance of CustomerDAL in BLL 
        private CustomerDAL customerDAL;

        #region Ctor
        // BLL ctor creating an object of CustomerDAL
        public CustomerBLL(CustomerDAL customerDAL)
        {
            this.customerDAL = customerDAL;
        }
        #endregion

        #region Create
        // method to create customers (and throw exception otherwise)
        public void Create(Customer tmp)
        {
            try
            {
                customerDAL.Create(tmp); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught in Create in Customer BLL");
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion

        #region Read All
        // method to read all customers in list (and throw exception otherwise)
        public List<Customer> ReadAll()
        {
            try
            {
                return customerDAL.ReadAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught in Read All in Customer BLL");
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion

        #region Read One
        // method to read customer by ID (and throw exception otherwise)
        public Customer Read(int customerID)
        {
            try
            {
                return customerDAL.Read(customerID);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught in Read in Customer BLL");
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion

        #region Update
        // method to update customers (and throw exception otherwise)
        public void Update(Customer tmp)
        {
            try
            {
                customerDAL.Update(tmp);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught in Update in Customer BLL");
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion

        #region Delete
        // method to delete customers (and throw exception otherwise)
        public void Delete(Customer tmp)
        {
            try
            {
                customerDAL.Delete(tmp);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught in Delete in Customer BLL");
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion
    }
}