using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Listing1._3
{
    /// <summary>
    /// A dimenstration for the method For of the Parallel class.
    /// The Parallel.For method can be used to parallelize the execution of a for loop,
    /// which is governed by a control variable (see Listing 1-3).
    /// </summary>
    class Program
    {
        static void WorkOnItem(object item)
        {
            Console.WriteLine("Started working on: " + item);
            Thread.Sleep(100);
            Console.WriteLine("Finished working on: " + item);
        }
        /// <summary>
        /// This implements a counter starting at 0 (the first parameter of the Parallel.For method),
        /// for the length of the items array (the second parameter of the Parallel.For method).
        /// The third parameter of the method is a lambda expression, 
        /// which is passed a variable that provides the counter value for each iteration.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var items = Enumerable.Range(0, 500).ToArray();
            Parallel.For(0, items.Length, i =>
            {
                WorkOnItem(items[i]);
            });
            Console.WriteLine("Finished Processing. Press any key to continue.");
            Console.ReadKey();
        }
    }
}
