using System;
using System.Threading;

namespace LISTING_1_24_shared_flag_variable
{
    /// <summary>
    /// When a thread is aborted it is instantly stopped. 
    /// This might mean that it leaves the program in an ambiguous state, with files open and resources assigned.
    /// A better way to abort a thread is to use a shared flag variable.
    /// </summary>
    class Program
    {
        static bool tickRunning; //flag variable
        static void Main(string[] args)
        {
            tickRunning = true;
            Thread tickThread = new Thread(() => 
            {
                while (tickRunning)
                {
                    Console.WriteLine("Tick");
                    Thread.Sleep(1000);
                }
            });
            tickThread.Start();
            Console.WriteLine("Press a key to stop the clock");
            Console.ReadKey();
            tickRunning = false;

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
