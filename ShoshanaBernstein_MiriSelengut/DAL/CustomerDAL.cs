using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        static List<Customer> list = new List<Customer>();
        static readonly CustomerDAL instance = new CustomerDAL();
        public static CustomerDAL Instance { get { return instance; } }
        
        #region Ctor
        //ctor that intializes list to customers in the text file
        private CustomerDAL()
        {
            InitializeList();
        }
        #endregion

        #region InitializeList
        //initializes the list to the information in the text file
        public void InitializeList()
        {
            string[] lines = File.ReadAllLines(@"../../../DAL/CustomerList.txt");

            //for each line in the file create a new object
            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');
                string customerName = parts[0];
                int customerID = int.Parse(parts[1]);

                Customer newCustomer = new Customer(customerName, customerID);

                //add the objects to the list
                list.Add(newCustomer);
            }

        }
        #endregion

        #region Create
        //method to add a new object to list
        public void Create(Customer tmp)
        {
            try
            {
                //Check if a customer with the same customerID already exists
                bool exists = list.Any(p => p.CustomerID == tmp.CustomerID);
                //if it doesn't exit
                if (exists)
                {
                    throw new DuplicateCustomerID();
                }
                else
                {
                    Customer newCustomer = new Customer(
                        tmp.CustomerName,
                        tmp.CustomerID
                        );
                    //add it to the list
                    list.Add(newCustomer);
                }
            }
            catch (DuplicateProductNumber ex)
            {
                Console.WriteLine("\nCaught in Create in CustomerDAL");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Throwing to CustomerBLL");
                throw;
            }
        }
        #endregion

        #region Read one Customer
        //method to return one customer according to ID
        public Customer Read(int customerID)
        {
            try
            {
                // finding customer based on ID
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].CustomerID == customerID)
                    {
                        // Return a copy of the customer
                        return new Customer(list[i].CustomerName, list[i].CustomerID);
                    }
                }

                throw new CustomerIDNotFound();
            }
            catch (CustomerIDNotFound ex)
            {
                Console.WriteLine("\nCaught in Read one in CustomerDAL");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Throwing to CustomerBLL");
                throw;
            }
        }
        #endregion

        #region Read all Customers
        public List<Customer> ReadAll()
        {
            // creating a new list, and adding each customer to list
            List<Customer> newList = new List<Customer>();

            foreach (Customer c in list)
            {
                newList.Add(new Customer(c.CustomerName, c.CustomerID));
            }

            // returning the new list
            return newList;
        }
        #endregion

        #region Update Customer
        public void Update(Customer tmp)
        {
            try
            {
                // finding customer based on ID
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].CustomerID == tmp.CustomerID)
                    {
                        list[i] = new Customer(tmp.CustomerName, tmp.CustomerID);
                        return;
                    }
                }

                throw new CustomerIDNotFound();
            }
            catch (CustomerIDNotFound ex)
            {
                Console.WriteLine("\nCaught in Update in CustomerDAL");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Throwing to CustomerBLL");
                throw;
            }
        }
        #endregion

        #region Delete Customer
        public void Delete(Customer tmp)
        {
            try
            {
                // finding customer based on ID
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].CustomerID == tmp.CustomerID)
                    {
                        list.RemoveAt(i);
                        return;
                    }
                }

                throw new CustomerIDNotFound();
            }
            catch (CustomerIDNotFound ex)
            {
                Console.WriteLine("\nCaught in Delete in CustomerDAL");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Throwing to CustomerBLL");
                throw;
            }
        }
        #endregion

        #region Print Customers
        public void Print()
        {
            foreach (Customer c in ReadAll())
            {
                Console.WriteLine($"{c.CustomerName} (ID: {c.CustomerID})");
            }
            Console.WriteLine();
        }
        #endregion

    }
}
