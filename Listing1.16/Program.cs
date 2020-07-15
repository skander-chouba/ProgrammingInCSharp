using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing1._16
{
    /// <summary>
    /// The ContinueWith method has an overload that you can use to specify when a given continuation task can run.
    /// This version accepts a parameter of type TaskContinuationOptions.
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
        static void Main(string[] args)
        {
            Task task = Task.Run(() => HelloTask());
            task.ContinueWith((prevTask) => WorldTask(), TaskContinuationOptions.OnlyOnRanToCompletion);
            task.ContinueWith((prevTask) => { Console.WriteLine("Sorry for your loss"); }, TaskContinuationOptions.OnlyOnFaulted);

            Console.WriteLine("Finished Process, press any key to continue...");
            Console.ReadKey();
        }
    }
}
