using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    // A class to create objects for each Person.
    public class Person
    {
        // Person's name
        public string Name { get; set; }

        // Person's ID number
        public int ID { get; set; }

        public Person(string Name, int ID)
        {
            this.Name = Name;
            this.ID = ID;
        }

        public override string ToString()
        {
            return $"Name: {Name}, ID: {ID}";
        }
    }
}
