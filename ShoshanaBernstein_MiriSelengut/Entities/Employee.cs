using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    // A class to create objects for each Employee. Inherets from Person.
    public class Employee : Person
    {
        // Employee's salary
        public int Salary { get; set; }

        public Employee(string Name, int ID, int Salary)
            : base(Name, ID)
        {
            this.Salary = Salary;
        }
    }
}
