using System;
using System.Threading;
using System.Threading.Tasks;

namespace LISTING_1_15_Continuation_tasks
{
    /// <summary>
    /// A continuation task can be nominated to start when an existing task (the antecedent task) finishes.
    /// If the antecedent task produces a result, it can be supplied as an input to the continuation task.
    /// Continuation tasks can be used to create a “pipeline” of operations, with each successive stage starting when the preceding one ends.
    /// </summary>
    class Program
    {
        public static void HelloTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Hello");
        }
        public static void WorldTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("World");
        }
        /// <summary>
        /// Listing 1-15 shows how a continuation task can be created from a task.
        /// A Task object exposes a ContinueWith method that can be used to specify a continuation task.
        /// The lambda expression that executes the continuation task is provided with a reference to the antecedent task,
        /// which it can use to determine if the antecedent completed successfully.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Task task = Task.Run(() => HelloTask());
            task.ContinueWith((prevTask) => WorldTask());

            Console.WriteLine("Finished Process, press any key to continue...");
            Console.ReadKey();
        }
    }
}
