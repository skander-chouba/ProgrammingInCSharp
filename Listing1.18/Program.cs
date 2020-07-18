using System;
using System.Threading;

namespace LISTING_1_18_Creating_threads
{
    /// <summary>
    /// The Thread class is located in the System.Threading namespace.
    /// When you create a Thread you can pass the constructor the name of the method the thread will run. 
    /// Once the thread has been created, you can call the Start method on the thread to start it running.
    /// </summary>
    class Program
    {
        static void ThreadHello()
        {
            Console.WriteLine("Hello from the thread");
            Thread.Sleep(2000);
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(ThreadHello);
            thread.Start();

            Console.WriteLine("Finished Processing, press any key to continue...");
            Console.ReadKey();
        }
    }
}
