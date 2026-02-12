using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Entities
{
    // A class to create objects for each Manager. Inherets from Person.
    internal class Manager : Employee
    {
        public Manager(string Name, int ID, int Salary) : base (Name, ID, Salary)
        {
            
        }

        public override string ToString()
        {
            return "\nName: " + Name + "\nID: " + ID + "\nSalary: " + Salary;
        }
    }
}
