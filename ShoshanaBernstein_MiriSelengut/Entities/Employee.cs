using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    internal class Employee : Person
    {
        public int Salary { get; set; }
        public Employee(string name, int id, int salar)
            : base(name, id)
        {
            
        }
    }
}
