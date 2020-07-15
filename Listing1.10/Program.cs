using System;
using System.Linq;

namespace Listing1._10
{
    /// <summary>
    /// The code in Listing 1-10 uses the CheckCity method in a query. This will cause exceptions to be thrown when empty city names are encountered during the query.
    /// If any queries generate exceptions an AgregateException will be thrown when the query is complete.
    /// This contains a list, InnnerExceptions, of the exceptions that were thrown during the query.
    /// </summary>
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public string City { get; set; }
        }
        public static bool CheckCity(Person person)
        {
            if (person.City == "")
                throw new ArgumentException(person.City);
            return person.City == "Seattle";
        }

        static void Main(string[] args)
        {
            Person[] people = new Person[] {
                new Person { Name = "Alan", City = "" },
                new Person { Name = "Beryl", City = "Seattle" },
                new Person { Name = "Charles", City = "" },
                new Person { Name = "David", City = "Seattle" },
                new Person { Name = "Eddy", City = "Paris" },
                new Person { Name = "Fred", City = "" },
                new Person { Name = "Henry", City = "Seattle" },
                new Person { Name = "Gordon", City = "" },
                new Person { Name = "Isaac", City = "Seattle" },
                new Person { Name = "James", City = "" }
            };

            try
            {
                var result = from person in people.AsParallel()
                             where CheckCity(person)
                             select person;
                result.ForAll(person => Console.WriteLine(person.Name));
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.InnerExceptions.Count + " exceptions.");
            }
            Console.WriteLine("Finished Processing, press any key to continue...");
            Console.ReadKey();
        }
    }
}
