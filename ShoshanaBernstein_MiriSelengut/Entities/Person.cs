using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Person(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }

        public override string ToString()
        {
            return $"Name: {Name}, ID: {ID}";
        }
    }
}
