using System;
using System.Threading;

namespace Listing1._19_Using_ThreadStart
{
    /// <summary>
    /// Note that earlier versions of .NET required the creation of a ThreadStart delegate to specify the method to be executed by the thread.
    /// It’s not currently necessary, but you may see it used in older programs.
    /// The ThreadStart delegate is no longer required.
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
            ThreadStart ts = new ThreadStart(ThreadHello);
            Thread thread = new Thread(ts);
            thread.Start();

            Console.WriteLine("Finished Processing, press any key to continue...");
            Console.ReadKey();
        }
    }
}
