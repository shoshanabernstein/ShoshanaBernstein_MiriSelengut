using System.Net.Http.Headers;

namespace Entities
{
   class Program
   {
      static void Main(string[] args)
        {
            Product p1 = new Product(1, "Milk", 5.5f);
            Person p2 = new Person("Shoshana", 123456789);
            Person p3 = new Person("Miri", 987654321);

            Person[] people = new Person[] {p2, p3};
            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name}, ID: {person.ID}");
            }
        }
    }
}