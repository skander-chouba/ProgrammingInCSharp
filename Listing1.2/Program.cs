using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Listing1._2
{
    /// <summary>
    /// A dimenstration for the method Foreach of the Parallel class.
    /// The Task.Parallel class also provides a ForEeach method that performs
    /// a parallel implementation of the foreach loop construction, as shown in
    /// Listing 1-2, in which the WorkOnItem method is called to process each of the
    /// items in a list.
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
        /// The Parallel.ForEach method accepts two parameters. The first parameter is an IEnumerable collection (in this case the list items).
        /// The second parameter provides the action to be performed on each item in the list.
        /// You can see some of the output from this program below. 
        /// Note that the tasks are not completed in the same order that they were started.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var items = Enumerable.Range(0, 500);
            Parallel.ForEach(items, item =>
            {
                WorkOnItem(item);
            });
            Console.WriteLine("Finished Processing. Press any key to end.");
            Console.ReadKey();
        }
    }
}
