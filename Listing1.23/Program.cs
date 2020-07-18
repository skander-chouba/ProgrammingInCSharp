using System;
using System.Threading;

namespace LISTING_1_23_aborting_a_thread
{
    class Program
    {
        /// <summary>
        /// A Thread object exposes an Abort method, which can be called on the thread to abort it. 
        /// The thread is terminated instantly.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Thread tickThread = new Thread(() =>
            {
                while (true)
                {
                    Console.WriteLine("true");
                    Thread.Sleep(1000);
                }
            });
            tickThread.Start();
            Console.WriteLine("Press a key to stop the clock");
            Console.ReadKey();
            tickThread.Abort(); //This line causes a Plattform not supported exception!

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
