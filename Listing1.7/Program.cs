using System;
using System.Linq;

namespace Listing1._7
{
    /// <summary>
    /// The AsOrdered method doesn’t prevent the parallelization of the query,
    /// instead it organizes the output so that it is in the same order as the original data.
    /// This can slow down the query.
    /// </summary>
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string City { get; set; }
        }

        static void Main(string[] args)
        {
            Person[] people = new Person[] {
                new Person { Name = "Alan", City = "Hull" },
                new Person { Name = "Beryl", City = "Seattle" },
                new Person { Name = "Charles", City = "London" },
                new Person { Name = "David", City = "Seattle" },
                new Person { Name = "Eddy", City = "Paris" },
                new Person { Name = "Fred", City = "Berlin" },
                new Person { Name = "Gordon", City = "Hull" },
                new Person { Name = "Henry", City = "Seattle" },
                new Person { Name = "Isaac", City = "Seattle" },
                new Person { Name = "James", City = "London" }
            };

            var result = from person in people.AsParallel()
                         .AsOrdered()
                         where person.City == "Seattle"
                         select person;

            foreach (var person in result)
                Console.WriteLine(person.Name);

            Console.WriteLine("Finished Processing, press any key to continue...");
            Console.ReadKey();
        }
    }
}
