using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    // A class to create objects for each sales rep, inherts from Employee.
    internal class SalesRep : Employee
    {
        // Comission rate for sales rep
        public int CommissionRate { get; set; }

        public SalesRep(string Name, int ID, int Salary, int CommissionRate) : base (Name, ID, Salary)
        {
            this.CommissionRate = CommissionRate;
        }
    }
}
