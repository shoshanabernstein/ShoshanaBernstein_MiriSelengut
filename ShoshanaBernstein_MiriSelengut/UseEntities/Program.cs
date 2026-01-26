using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;

namespace UseEntities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product product = new Product(1, "Laptop", 999.99);
            //Person  person = new Person("Alice", 101);
            //Person person1 = new Person("Bob", 102);
            //Person person2 = new Person("Charlie", 103);

            //Person[] people = new Person[3];
            //people[0] = person;
            //people[1] = person1;
            //people[2] = person2;

            //for(int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine(people[i].Name + people[i].ID);
            //}

            Person[] people = new Person[10];


            string[] lines = File. ReadAllLines(@"..\..\Text.txt");

            int index = 0;

            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');

                string name = parts[0];
                int id = int.Parse(parts[1]);

                if (index < people.Length)
                {
                    people[index] = new Person(name, id);
                    index++;
                }

            }

            foreach (Person person in people)
            {
                if (person != null)
                {
                    Console.WriteLine(person);
                }
            }
        }
    }
}
