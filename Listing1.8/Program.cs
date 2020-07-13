using System;
using System.Linq;

namespace Listing1._8
{
    /// <summary>
    /// The AsSequential method can be used to identify parts of a query that must be sequentially executed.
    /// AsSequential executes the query in order whereas AsOrdered returns a sorted result but does not necessarily run the query in order.
    /// </summary>
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string City { get; set; }
        }

        /// <summary>
        /// The query requests that the result be ordered by person name, and this ordering is preserved by the use of AsSequential before the Take, which removes the four people.
        /// If the Take is executed in parallel it can disrupt the ordering of the result.
        /// </summary>
        /// <param name="args"></param>
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
            
            var result = (from person in people.AsParallel()
                          where person.City == "Seattle"
                          orderby (person.Name)
                          select new
                          {
                              person.Name
                          }).AsSequential().Take(4);

            foreach (var person in result)
                Console.WriteLine(person.Name);

            Console.WriteLine("Finished Processing, press any key to continue...");
            Console.ReadKey();
        }
    }
}
