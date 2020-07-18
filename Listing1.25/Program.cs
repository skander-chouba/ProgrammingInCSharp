using System;
using System.Threading;

namespace Listing1._25_Using_Join
{
    /// <summary>
    /// The join method allows two threads to synchronize. 
    /// When a thread calls the join method on another thread, the caller of join is held until the other thread completes.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Thread threadToWaitFor = new Thread(() =>
            {
                Console.WriteLine("Thread starting");
                Thread.Sleep(2000);
                Console.WriteLine("Thread done");
            });

            threadToWaitFor.Start();
            Console.WriteLine("Joining thread");
            threadToWaitFor.Join();

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
