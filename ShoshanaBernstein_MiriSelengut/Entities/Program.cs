using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalesRep salesRep = new SalesRep("Miri Sales Rep", 6474, 500, 5);
            Console.WriteLine(salesRep);

            Customer customer = new Customer("Miri Customer", 6474);
            Console.WriteLine(customer);

            Manager manager = new Manager("Miri Manager", 6474, 500);
            Console.WriteLine(manager);

            Product prodcut = new Product(3158, "Diet coke", 9.10m, 100);
            Console.WriteLine(prodcut);

            CreditCard creditCard = new CreditCard("Miri Selengut", "1234 5678 9101 1213", "Sep", "06", "123");
            Console.WriteLine(creditCard);
        }
    }
}
