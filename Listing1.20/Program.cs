using System;
using System.Threading;

namespace Listing1._20_Threads_and_lambda_expressions
{
    /// <summary>
    /// It is possible to start a thread using a lambda expression to specify the action of the thread.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(() =>
            {
                Console.WriteLine("Hello from the thread");
                Thread.Sleep(1000);
            });
            thread.Start();

            Console.WriteLine("Press a key to end.");
            Console.ReadKey();
        }
    }
}
