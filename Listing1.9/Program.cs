using System;
using System.Linq;

namespace Listing1._9
{
    /// <summary>
    /// The ForAll method can be used to iterate through all of the elements in a query.
    /// It differs from the foreach C# construction in that the iteration takes place in parallel and will start before the query is complete.
    /// The parallel nature of the execution of ForAll means that the order of the printed output above will not reflect the ordering of the input data.
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
                         where person.City == "Seattle"
                         select person;
            result.ForAll(person => Console.WriteLine(person.Name));

            Console.WriteLine("Finished Processing, press any key to continue...");
            Console.ReadKey();
        }
    }
}
