using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Listing1._4
{
    /// <summary>
    /// Managing Parallel.For and Parallel.Foreach
    /// The lambda expression that executes each iteration of the loop can be provided
    /// with an additional parameter of type ParallelLoopState that allows the code being iterated to control the iteration process.
    /// The For and ForEach methods also return a value of type ParallelLoopResult that can be used to determine whether or not a parallel loop has successfully completed.
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
        /// The iterations can be ended by calling the Stop or Break methods on the ParallelLoopState variable.
        /// Calling Stop will prevent any new iterations with an index value greater than the current index.
        /// If Stop is used to stop the loop during the 200th iteration it might be that iterations with an index lower than 200 will not be performed.
        /// If Break is used to end the loop iteration, all the iterations with an index lower than 200 are guaranteed to be completed before the loop is ended.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var items = Enumerable.Range(0, 500).ToArray();
            ParallelLoopResult result = Parallel.For(0, items.Count(), (int i, ParallelLoopState P) => 
            {
                if (i == 200)
                {
                    P.Stop();
                }
                WorkOnItem(items[i]);
            });
            Console.WriteLine("Completed: " + result.IsCompleted);
            Console.WriteLine("Items: " + result.LowestBreakIteration); // Works only if you change Stop to Break.
            Console.WriteLine("Finished Processing. Press any key to end.");
            Console.ReadKey();
        }
    }
}
