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
    public class OrderDAL
    {
        static List<Order> list = new List<Order>();
        static readonly OrderDAL instance = new OrderDAL();
        public static OrderDAL Instance { get { return instance; } }

        #region Ctor
        //ctor that intializes list of orders in the text file
        private OrderDAL()
        {
            InitializeList();
        }
        #endregion

        #region InitializeList
        //initializes the list to the information in the text file
        public void InitializeList()
        {
            string[] lines = File.ReadAllLines(@"../../../DAL/OrderList.txt");

            //for each line in the file create a new object
            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');
                int productID = int.Parse(parts[0]);
                int customerID = int.Parse(parts[1]);
                int orderQuantity = int.Parse(parts[2]);

                Order newOrder = new Order(productID, customerID, orderQuantity);

                //add the order to the list
                list.Add(newOrder);
            }

        }
        #endregion

        #region Create
        //method to add a new object to list
        public void Create(Order tmp)
        {
            try
            {
                //Check if an order with the same OrderID already exists
                bool exists = list.Any(p => p.OrderID == tmp.OrderID);

                //if it doesn't exist
                if (exists)
                {
                    throw new DuplicateOrderID();
                }
                else
                {
                    Order newOrder = new Order(
                        tmp.ProductID,
                        tmp.CustomerID,
                        tmp.OrderQuantity
                        );

                    //add it to the list
                    list.Add(newOrder);
                }
            }
            catch (DuplicateOrderID ex)
            {
                Console.WriteLine("\nCaught in Create in OrderDAL");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Throwing to OrderBLL");
                throw;
            }
        }
        #endregion

        #region Read one Order
        //method to return one order according to ID
        public Order Read(int orderNumber)
        {
            try
            {
                // finding order based on ID
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].OrderID == orderNumber)
                    {
                        // Return a copy of the order
                        Order readOrder = new Order(
                            list[i].ProductID,
                            list[i].CustomerID,
                            list[i].OrderQuantity
                        );
                        readOrder.OrderID = list[i].OrderID;
                        return readOrder;
                    }
                }

                throw new OrderIDNotFound();
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

        #region Read by customer
        //method to return one order according to ID
        public Order ReadCustomer(int customerID)
        {
            try
            {
                // finding order based on customer
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].CustomerID == customerID)
                    {
                        // Return a copy of the order
                        Order readCustomerOrder = new Order(
                            list[i].ProductID,
                            list[i].CustomerID,
                            list[i].OrderQuantity
                        );
                        readCustomerOrder.OrderID = list[i].OrderID;
                        return readCustomerOrder;
                    }
                }

                throw new CustomerIDNotFound();
            }
            catch (CustomerIDNotFound ex)
            {
                Console.WriteLine("\nCaught in Read one in OrderDAL");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Throwing to OrderBLL");
                throw;
            }
        }
        #endregion

        #region Read by product
        //method to return one order according to ID
        public Order ReadProduct(int productID)
        {
            try
            {
                // finding order based on product
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ProductID == productID)
                    {
                        // Return a copy of the order
                        Order readProductOrder = new Order(
                            list[i].ProductID,
                            list[i].CustomerID,
                            list[i].OrderQuantity
                        );
                        readProductOrder.OrderID = list[i].OrderID;
                        return readProductOrder;
                    }
                }

                throw new ProductIDNotFound();
            }
            catch (ProductIDNotFound ex)
            {
                Console.WriteLine("\nCaught in Read one in OrderDAL");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Throwing to OrderBLL");
                throw;
            }
        }
        #endregion

        #region Read all Orders
        public List<Order> ReadAll()
        {
            // creating a new list, and adding each order to list
            List<Order> newList = new List<Order>();

            foreach (Order o in list)
            {
                Order copy = new Order(o.ProductID, o.CustomerID, o.OrderQuantity);
                copy.OrderID = o.OrderID;
                newList.Add(copy);
            }

            // returning the new list
            return newList;
        }
        #endregion

        #region Update Order
        public void Update(int orderID)
        {
            try
            {
                // finding order based on ID
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].OrderID == orderID)
                    {
                        Order newOrder = new Order(
                            tmp.ProductID,
                            tmp.CustomerID,
                            tmp.OrderQuantity
                        );
                        newOrder.OrderID = tmp.OrderID;

                        list[i] = newOrder;
                        return;
                    }
                }

                throw new OrderIDNotFound();
            }
            catch (OrderIDNotFound ex)
            {
                Console.WriteLine("\nCaught in Update in OrderDAL");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Throwing to OrderBLL");
                throw;
            }
        }
        #endregion

        #region Delete Order
        public void Delete(Order tmp)
        {
            try
            {
                // finding order based on ID
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].OrderID == tmp.OrderID)
                    {
                        list.RemoveAt(i);
                        return;
                    }
                }

                throw new OrderIDNotFound();
            }
            catch (OrderIDNotFound ex)
            {
                Console.WriteLine("\nCaught in Delete in OrderDAL");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Throwing to OrderBLL");
                throw;
            }
        }
        #endregion

        #region Print Orders
        public void Print()
        {
            foreach (Order o in ReadAll())
            {
                Console.WriteLine(
                    $"Order #{o.OrderID} | Product: {o.ProductID} | Customer: {o.CustomerID} | Qty: {o.OrderQuantity}"
                );
            }
            Console.WriteLine();
        }
        #endregion
    }
}